using Bogus;
using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Enums;

namespace CommonTestUtilities.Entities
{
    public class ItemBuilder
    {
        public static IList<Item> Collection(User user, uint count = 2)
        {
            var list = new List<Item>();

            if (count == 0)
                count = 1;

            var recipeId = 1;

            for (int i = 1; i < count; i++)
            {
                var fakeRecipe = Build(user);
               fakeRecipe.Id = recipeId++;

                list.Add(fakeRecipe);
            }

            return list;
        }

        public static Item Build(User user)
        {
            return new Faker<Item>()
                .RuleFor(i => i.Id, 1)
                .RuleFor(i => i.Name, f => f.Commerce.ProductName())
                .RuleFor(i => i.Brand, f => f.Company.CompanyName())
                .RuleFor(i => i.Employee, f => f.Person.FirstName)
                .RuleFor(i => i.InternalCode, "1152")
                .RuleFor(i => i.Department, f => f.PickRandom<Department>())
                .RuleFor(i => i.ProductType, f => f.PickRandom<ProductType>())
                .RuleFor(i => i.ItemStatus, f => f.PickRandom<ItemStatus>())
                .RuleFor(i => i.UserId, () => user.Id);
        }
    }
}
