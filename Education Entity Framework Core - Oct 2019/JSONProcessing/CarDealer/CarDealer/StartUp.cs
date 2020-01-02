using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using AutoMapper;
using CarDealer.Data;
using CarDealer.DTO;
using CarDealer.Models;
using Newtonsoft.Json;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            var input = File.ReadAllText(@"C:\Users\Lady Gaba\source\repos\EntityFrameworkCore\JSONProcessing\CarDealer\CarDealer\Datasets\sales.json");

            using (var db = new CarDealerContext())
            {

                //db.Database.EnsureDeleted();
                //db.Database.EnsureCreated();

                var result = GetSalesWithAppliedDiscount(db);

                Console.WriteLine(result);

            }

        }

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var objSupplier = JsonConvert.DeserializeObject<Supplier[]>(inputJson);

            context.Suppliers.AddRange(objSupplier);

            context.SaveChanges();

            return $"Successfully imported {context.Suppliers.Count()}.";
        }

        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            var objParts = JsonConvert.DeserializeObject<Part[]>(inputJson);

            var suppliers = context.Suppliers.Select(s => s.Id).ToList();

            foreach (var item in objParts)
            {
                if (suppliers.Contains(item.SupplierId))
                {
                    context.Parts.Add(item);
                    context.SaveChanges();
                }
            }

            return $"Successfully imported {context.Parts.Count()}.";
        }

        public static string ImportCars(CarDealerContext context, string inputJson)
        {

            var carsDto = JsonConvert.DeserializeObject<ImportCarDto[]>(inputJson);

            var cars = new List<Car>();
            var carParts = new List<PartCar>();


            foreach (var carDto in carsDto)
            {

                var car = new Car()
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TravelledDistance = carDto.TravelledDistance
                };

                foreach (var part in carDto.PartsId.Distinct())
                {
                    var carPart = new PartCar()
                    {
                        PartId = part,
                        Car = car

                    };

                    carParts.Add(carPart);
                }

                cars.Add(car);
            }

            context.Cars.AddRange(cars); // add the list of cars to Car class

            context.PartCars.AddRange(carParts);// add the list of parts to PartCar class

            context.SaveChanges();

            return $"Successfully imported {cars.Count()}.";
        }


        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            var importCustomers = JsonConvert.DeserializeObject<Customer[]>(inputJson);

            context.Customers.AddRange(importCustomers);

            context.SaveChanges();

            return $"Successfully imported {importCustomers.Count()}.";
        }


        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            var importedSales = JsonConvert.DeserializeObject<Sale[]>(inputJson);

            context.Sales.AddRange(importedSales);

            context.SaveChanges();

            return $"Successfully imported {context.Sales.Count()}.";

        }

        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                                   .OrderBy(c => c.BirthDate)
                                   .ThenBy(c => c.IsYoungDriver)
                                   .Select(c => new
                                   {
                                       Name = c.Name,
                                       BirthDate = c.BirthDate
                                                  .Date
                                                  .ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                                       IsYoungDriver = c.IsYoungDriver

                                   })
                                   .ToList();

            var jsonCustomers = JsonConvert.SerializeObject(customers, Formatting.Indented);

            return jsonCustomers;

        }

        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars
                              .Where(c => c.Make == "Toyota")
                              .OrderBy(c => c.Model)
                              .ThenByDescending(c => c.TravelledDistance)
                              .Select(c => new
                              {
                                  Id = c.Id,
                                  Make = c.Make,
                                  Model = c.Model,
                                  TravelledDistance = c.TravelledDistance

                              })
                              .ToList();

            var jsonCars = JsonConvert.SerializeObject(cars, Formatting.Indented);

            return jsonCars;

        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var localSuppliersList = context.Suppliers
                                            .Where(s => s.IsImporter == false)
                                            .Select(s => new
                                            {
                                                Id = s.Id,
                                                Name = s.Name,
                                                PartsCount = s.Parts.Count()
                                            })
                                            .ToList();

            var jsonLocalSuppliers = JsonConvert.SerializeObject(localSuppliersList, Formatting.Indented);

            return jsonLocalSuppliers;


        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {

            var cars = context.Cars.Select(s => new
            {
                car = new
                {
                    Make = s.Make,
                    Model = s.Model,
                    TravelledDistance = s.TravelledDistance
                },

                parts = s.PartCars.Select(p => new
                {
                    Name = p.Part.Name,
                    Price = $"{p.Part.Price:f2}"

                })


            }).ToList();


            var jsonCars = JsonConvert.SerializeObject(cars, Formatting.Indented);

            return jsonCars;




        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var totalSales = context.Customers
                                    .Where(c => c.Sales.Count > 0)
                                    .Select(c => new
                                    {
                                        fullName = c.Name,
                                        boughtCars = c.Sales.Count(),
                                        spentMoney = c.Sales.Sum(s => s.Car.PartCars.Sum(cp => cp.Part.Price))
                                    })
                                    .OrderByDescending(c => c.spentMoney)
                                    .ThenByDescending(c => c.boughtCars)
                                    .ToList();

            var jsonCars = JsonConvert.SerializeObject(totalSales, Formatting.Indented);

            return jsonCars;
        }


        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {

            var sales = context.Sales
                .Select(s => new
                {
                    car = new
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance

                    },

                    customerName = s.Customer.Name,
                    Discount = $"{s.Discount:f2}",
                    price = $"{s.Car.PartCars.Sum(pc => pc.Part.Price):f2}",
                    priceWithDiscount = $"{((s.Car.PartCars.Sum(pc => pc.Part.Price)) * (1-(s.Discount/100))):f2}"


                })
                .Take(10)
                .ToList();

            var jsonSales = JsonConvert.SerializeObject(sales, Formatting.Indented);

            return jsonSales;

        }

        //





    }
}