namespace EGovernment.Web.Areas.Administration.Services
{
    using System.Linq;

    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Services.Mapping;

    public class AddressService : IAddressService
    {
        private readonly IDeletableEntityRepository<Address> addressRepository;

        public AddressService(
            IDeletableEntityRepository<Address> addressRepository)
        {
            this.addressRepository = addressRepository;
        }

        public bool AddressExists(int id)
        {
            var address = this.addressRepository.All().Where(x => x.Id == id).FirstOrDefault();
            if (address == null)
            {
                return false;
            }

            return true;
        }

        public void DeleteAsync(int id) // for admin only
        {
            var address = this.addressRepository.All().Where(x => x.Id == id).FirstOrDefault();
            if (address != null)
            {
                this.addressRepository.Delete(address);
                this.addressRepository.SaveChangesAsync();
            }
        }

        public T GetAddressById<T>(int id)
        {
            var address = this.addressRepository.All().Where(x => x.Id == id);
            return address.To<T>().First();
        }

        public void UpdateAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
