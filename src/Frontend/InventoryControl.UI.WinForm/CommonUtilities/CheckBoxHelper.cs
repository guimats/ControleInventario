namespace InventoryControl.UI.WinForms.CommonUtilities;

public static class CheckBoxHelper
{

    // função para criar check boxes com valores de um Enum em um GroupBox
    public static void CreateCheckBoxes<TEnum>(GroupBox groupBox, int itensPerColumn = 4) where TEnum : Enum
    {
        var values = Enum.GetValues(typeof(TEnum));

        int column = 0;
        int line = 0;

        foreach (var value in values)
        {
            CheckBox checkBox = new()
            {
                Text = value.ToString()!.Replace("_", " "),
                Tag = value,
                AutoSize = true,
                Left = 10 + (column * 120),
                Top = 20 + (line * 25)
            };

            groupBox.Controls.Add(checkBox);

            line++;

            if (line >= itensPerColumn)
            {
                line = 0;
                column++;
            }
        }
    }

    public static IList<TEnum> GetValues<TEnum>(GroupBox groupBox) where TEnum : Enum
    {
        return groupBox
            .Controls.OfType<CheckBox>()
            .Where(cb => cb.Checked)
            .Select(cb => (TEnum)cb.Tag!)
            .ToList();
    }
}
