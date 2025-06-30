using InventoryControl.Infrastructure.Security.Tokens.Access.Generator;

namespace CommonTestUtilities.Tokens
{
    public class JwtTokenGeneratorBuilder
    {
        public static JwtTokenGenerator Build()
        {
            return new JwtTokenGenerator(expirationTimeMinutes: 1000, signingKey: "tttttttttttttttttttttttttttttttt");
        }
    }
}
