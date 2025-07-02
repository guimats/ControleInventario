using Bogus;
using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Enums;

namespace CommonTestUtilities.Entities
{
    public class ItemBuilder
    {
        public static Item Build(User user)
        {
            return new Faker<Item>()
                .RuleFor(i => i.Id, 1)
                .RuleFor(i => i.Name, f => f.Commerce.ProductName())
                .RuleFor(i => i.Brand, f => f.Company.CompanyName())
                .RuleFor(i => i.Employee, f => f.Person.FirstName)
                .RuleFor(i => i.Department, f => f.PickRandom<Department>())
                .RuleFor(i => i.ProductType, f => f.PickRandom<ProductType>())
                .RuleFor(i => i.ItemStatus, f => f.PickRandom<ItemStatus>())
                .RuleFor(i => i.UserId, () => user.Id);
        }
    }
}
