using Bogus;
using InventoryControl.Communication.Enums;
using InventoryControl.Communication.Requests;

namespace CommonTestUtilities.Requests
{
    public class RequestItemJsonBuilder
    {
        public static RequestItemJson Build()
        {
            return new Faker<RequestItemJson>()
                .RuleFor(i => i.Name, f => f.Commerce.ProductName())
                .RuleFor(i => i.Brand, f => f.Company.CompanyName())
                .RuleFor(i => i.Employee, f => f.Person.FirstName)
                .RuleFor(i => i.InternalCode, "0120")
                .RuleFor(i => i.Department, f => f.PickRandom<Department>())
                .RuleFor(i => i.ProductType, f => f.PickRandom<ProductType>())
                .RuleFor(i => i.ItemStatus, f => f.PickRandom<ItemStatus>());
        }
    }
}
