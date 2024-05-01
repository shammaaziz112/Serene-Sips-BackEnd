using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;

public interface IAddressService
{
    public IEnumerable<AddressReadDto> FindAll();
    public AddressReadDto? FindOne(string id);
    public AddressReadDto CreateOne(Address address);
    public AddressReadDto? UpdateOne(string id, Address address);
    public bool DeleteOne(string id);
}
