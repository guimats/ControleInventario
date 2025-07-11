using Bogus;
using InventoryControl.Communication.Enums;
using InventoryControl.Communication.Requests;

namespace CommonTestUtilities.Requests
{
    public class RequestFilterItemJsonBuilder
    {
        public static RequestFilterItemJson Build()
        {
            return new Faker<RequestFilterItemJson>()
                .RuleFor(item => item.ItemName, f => f.Person.FirstName)
                .RuleFor(item => item.InternalCode, "0155")
                .RuleFor(item => item.Departments, f => f.Make(1, () => f.PickRandom<Department>()))
                .RuleFor(item => item.ProductTypes, f => f.Make(1, () => f.PickRandom<ProductType>()))
                .RuleFor(item => item.ItemStatus, f => f.PickRandom<ItemStatus>());
        }
    }
}
