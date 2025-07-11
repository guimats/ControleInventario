using Bogus;
using InventoryControl.Domain.Entities;
using InventoryControl.Infrastructure.Helpers;

namespace CommonTestUtilities.Entities
{
    public class ItemHistoryBuilder
    {
        public static IList<ItemHistory> Collection(User user, uint count = 2)
        {
            var list = new List<ItemHistory>();

            if (count == 0)
                count = 1;

            var id = 1;

            for (int i=1; i <= count; i++)
            {
                var history = Build(user);
                history.Id = id++;

                list.Add(history);
            }

            return list;
        }

        public static ItemHistory Build(User user, Item? oldItem = null, Item? newItem = null)
        {
            oldItem ??= ItemBuilder.Build(user);
            newItem ??= ItemBuilder.Build(user);

            return new Faker<ItemHistory>()
                .RuleFor(history => history.Id, 1)
                .RuleFor(history => history.ItemId, newItem.Id)
                .RuleFor(history => history.Action, "Update")
                .RuleFor(history => history.UserName, f => f.Person.FirstName)
                .RuleFor(history => history.OldData, JsonHelper.Serialize(oldItem))
                .RuleFor(history => history.NewData, JsonHelper.Serialize(newItem));
        }
    }
}
