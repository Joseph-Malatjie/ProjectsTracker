using Domain.Address;
using Domain.Dto.Commands;

namespace Application.Handlers.Commands.User;

public static class Helper
{
    public static List<Address> Addresses(List<AddressDto> addresses)
    {
        var address = addresses.Select(item => 
            new Address { City = item.City, PostalCode = item.PostalCode, StreetName = item.StreetName, Surburb = item.Surburb }).ToList();
        return address;
    }
}