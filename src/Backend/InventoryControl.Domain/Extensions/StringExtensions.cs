using System.Diagnostics.CodeAnalysis;

namespace InventoryControl.Domain.Extensions
{
    public static class StringExtensions
    {
        public static bool NotEmpty([NotNullWhen(true)] this string? value) => !string.IsNullOrWhiteSpace(value);
    }
}
