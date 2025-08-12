using InventoryControl.Communication.Enums;

namespace InventoryControl.UI.WinForms.Helpers;

public static class MapHelpers
{
    public static readonly Dictionary<string, string> FieldNameMap = new(StringComparer.OrdinalIgnoreCase)
    {
        { "name", "Nome" },
        { "brand", "Marca" },
        { "employee", "Funcionário" },
        { "internalCode", "Código" },
        { "department", "Departamento" },
        { "productType", "Tipo" },
        { "itemStatus", "Status" },
        { "active", "Ativo" }
    };

    public static readonly Dictionary<string, Type> EnumFieldsMap = new(StringComparer.OrdinalIgnoreCase)
    {
        { "department", typeof(Department) },
        { "productType", typeof(ProductType) },
        { "itemStatus", typeof(ItemStatus) }
    };
}
