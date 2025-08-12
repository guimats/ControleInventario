using FluentMigrator;

namespace InventoryControl.Infrastructure.Migrations.Versions
{
    [Migration(4, "Adjusting OnDelete method for ItemHistory table")]
    public class Version000004 : VersionBase
    {
        public override void Up()
        {
            Delete.ForeignKey("FK_ItemHistory_Item_Id").OnTable("ItemHistories");

            Create.ForeignKey("FK_ItemHistory_Item_Id")
                .FromTable("ItemHistories").ForeignColumn("ItemId")
                .ToTable("Itens").PrimaryColumn("Id")
                .OnDelete(System.Data.Rule.Cascade);
        }
    }
}
