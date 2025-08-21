using FluentMigrator;

namespace InventoryControl.Infrastructure.Migrations.Versions
{
    [Migration(5, "Add Role column to users table")]
    public class Version000005 : VersionBase
    {
        public override void Up()
        {
            Alter.Table("Users")
                .AddColumn("Role").AsInt32().NotNullable().WithDefaultValue(1);
        }
    }
}
