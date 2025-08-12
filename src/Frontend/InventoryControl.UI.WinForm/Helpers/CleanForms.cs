namespace InventoryControl.UI.WinForms.Helpers;

public static class CleanForms
{
    public static void CleanFields(Control.ControlCollection controls)
    {
        foreach (Control ctrl in controls)
        {
            if (ctrl is TextBox textBox)
                textBox.Clear();

            else if (ctrl is ComboBox comboBox)
                StandardValues.SetComboBoxValue(comboBox);

            else if (ctrl is CheckBox checkBox)
                checkBox.Checked = false;

            else if (ctrl is RadioButton radioButton)
                radioButton.Checked = false;
        }

        foreach (var group in controls.OfType<GroupBox>())
            CleanControls(group.Controls);
    }

    public static void CleanControls(Control.ControlCollection controls)
    {
        foreach (Control ctrl in controls)
        {
            if (ctrl is TextBox textBox)
                textBox.Clear();

            else if (ctrl is ComboBox comboBox)
                StandardValues.SetComboBoxValue(comboBox);

            else if (ctrl is CheckBox checkBox)
                checkBox.Checked = false;

            else if (ctrl is RadioButton radioButton)
                radioButton.Checked = false;

            else if (ctrl.HasChildren)
                CleanControls(ctrl.Controls);
        }
    }
}
