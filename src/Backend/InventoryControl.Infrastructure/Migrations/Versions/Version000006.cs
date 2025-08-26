using FluentMigrator;

namespace InventoryControl.Infrastructure.Migrations.Versions
{
    [Migration(6, "Create table to save the refresh token")]
    public class Version0000006 : VersionBase
    {
        public override void Up()
        {
            CreateTable("RefreshTokens")
                .WithColumn("Value").AsString().NotNullable()
                .WithColumn("UserId").AsInt64().NotNullable().ForeignKey("FK_RefreshTokens_User_Id", "Users", "Id");
        }
    }
}