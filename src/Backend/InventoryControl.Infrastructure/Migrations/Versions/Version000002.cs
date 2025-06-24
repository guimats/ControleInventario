using FluentMigrator;

namespace InventoryControl.Infrastructure.Migrations.Versions
{
    [Migration(2, "Create table to save the item's information")]
    public class Version000002 : VersionBase
    {
        public override void Up()
        {
            CreateTable("Itens")
                .WithColumn("Name").AsString(255).NotNullable()
                .WithColumn("Brand").AsString(255).Nullable()
                .WithColumn("Employee").AsString(255).Nullable()
                .WithColumn("InternalCode").AsString(10).NotNullable()
                .WithColumn("Department").AsInt32().Nullable()
                .WithColumn("ProductType").AsInt32().NotNullable()
                .WithColumn("ItemStatus").AsInt32().NotNullable()
                .WithColumn("UserId").AsInt64().NotNullable().ForeignKey("FK_Item_User_Id", "Users", "Id");
        }
    }
}
