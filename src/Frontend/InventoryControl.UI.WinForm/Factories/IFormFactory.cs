namespace InventoryControl.UI.WinForms.Factories;

public interface IFormFactory
{
    T Create<T>(Action<T>? configure = null) where T : Form;
    T Create<T>(Action<T>? configure = null, params object[] parameters) where T : Form;
}
