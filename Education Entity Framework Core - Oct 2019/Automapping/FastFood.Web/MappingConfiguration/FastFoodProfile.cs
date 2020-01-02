namespace FastFood.Web.MappingConfiguration
{
    using AutoMapper;
    using FastFood.Web.ViewModels.Categories;
    using FastFood.Web.ViewModels.Employees;
    using FastFood.Web.ViewModels.Items;
    using FastFood.Web.ViewModels.Orders;
    using Models;

    using ViewModels.Positions;

    public class FastFoodProfile : Profile
    {
        public FastFoodProfile()
        {
            //Positions
            this.CreateMap<CreatePositionInputModel, Position>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.PositionName));

            this.CreateMap<Position, PositionsAllViewModel>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.Name));

            this.CreateMap<Position, RegisterEmployeeViewModel>()
                .ForMember(x => x.PositionId, y => y.MapFrom(x => x.Id))
                .ForMember(x => x.PositionName, y => y.MapFrom(x => x.Name));

            // Employee
            this.CreateMap<RegisterEmployeeInputModel, Employee>()
                 .ForMember(x => x.Name, y => y.MapFrom(x => x.Name)); // this was added 

            this.CreateMap<Employee, EmployeesAllViewModel>()
                .ForMember(x => x.Position, y => y.MapFrom(x => x.Position.Name));

            this.CreateMap <Employee, CreateOrderInputModel>()
                 .ForMember(x => x.EmployeeId, y => y.MapFrom(x => x.Id));



            // Category - Id , Name, Items

            this.CreateMap<CreateCategoryInputModel, Category>()
                .ForMember(x => x.Name, y => y.MapFrom(x => x.CategoryName));


            this.CreateMap<Category, CategoryAllViewModel>()
                .ForMember(x => x.Name, y => y.MapFrom(x => x.Name)); // this was added

            this.CreateMap<Category, CreateItemViewModel>()
                .ForMember(x => x.CategoryId, y => y.MapFrom(x => x.Id));


            // Items - name, price Category --------- this was added

            this.CreateMap<CreateItemInputModel, Item>()
                .ForMember(x => x.Name, y => y.MapFrom(x => x.Name));

            this.CreateMap<Item, ItemsAllViewModels>()
                .ForMember(x => x.Name, y => y.MapFrom(x => x.Name));

            this.CreateMap<Item, OrderAllViewModel>()
                 .ForMember(x => x.OrderId, y => y.MapFrom(x => x.Id));


            //??

            // Orders 

            this.CreateMap <CreateOrderInputModel, Order>()
                 .ForMember(x => x.Customer, y => y.MapFrom(x => x.Customer));

            

        }
    }
}
