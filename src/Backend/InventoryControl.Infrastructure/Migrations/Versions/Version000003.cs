using FluentMigrator;

namespace InventoryControl.Infrastructure.Migrations.Versions
{
    [Migration(3, "Create table to save the item's history")]
    public class Version000003 : VersionBase
    {
        public override void Up()
        {
            CreateTable("ItemHistories")
                .WithColumn("ItemId").AsInt64().NotNullable().ForeignKey("FK_ItemHistory_Item_Id", "Itens", "Id")
                .WithColumn("Action").AsString(50).NotNullable()
                .WithColumn("UserName").AsString(255).NotNullable()
                .WithColumn("OldData").AsCustom("TEXT").Nullable()
                .WithColumn("NewData").AsCustom("TEXT").Nullable();
        }
    }
}
