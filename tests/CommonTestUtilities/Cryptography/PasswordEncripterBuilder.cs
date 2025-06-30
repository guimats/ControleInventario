using InventoryControl.Domain.Security.Cryptography;
using InventoryControl.Infrastructure.Services.Cryptography;

namespace CommonTestUtilities.Cryptography
{
    public class PasswordEncripterBuilder
    {
        public static IPasswordEncripter Build() => new Sha512Encripter("abc1234");
    }
}
