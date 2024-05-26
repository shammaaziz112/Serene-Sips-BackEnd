namespace sda_onsite_2_csharp_backend_teamwork.src.DTO;

public class AddressReadDto
{
    public Guid id { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Zip_code { get; set; }
}
public class AddressCreateDto
{
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Zip_code { get; set; }
}
