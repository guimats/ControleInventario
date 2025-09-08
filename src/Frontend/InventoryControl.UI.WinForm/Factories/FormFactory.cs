
using Microsoft.Extensions.DependencyInjection;

namespace InventoryControl.UI.WinForms.Factories
{
    // factory genérico para injetar dependencias aos forms
    public class FormFactory : IFormFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public FormFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public T Create<T>(Action<T>? configure = null) where T : Form
        {
            var form = _serviceProvider.GetRequiredService<T>();
            configure?.Invoke(form);
            return form;
        }

        public T Create<T>(Action<T>? configure = null, params object[] parameters) where T : Form
        {
            var form =  ActivatorUtilities.CreateInstance<T>(_serviceProvider, parameters);
            configure?.Invoke(form);
            return form;
        }
    }
}
