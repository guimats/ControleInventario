using InventoryControl.UI.WinForms.Exceptions.Handlers;
using InventoryControl.UI.WinForms.Helpers;

namespace InventoryControl.UI.WinForms.Exceptions
{
    public class ExceptionFilter
    {
        private readonly IEnumerable<IExceptionHandler> _handlers;

        public ExceptionFilter(IEnumerable<IExceptionHandler> handlers) => _handlers = handlers;

        public async Task ExecuteAsync(Func<Task> action)
        {
            try
            {
                await action();
            }
            catch (Exception ex)
            {
                foreach (var handler in _handlers)
                {
                    if (handler.Handle(ex))
                        return;
                }

                MessagesHelper.Error($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
