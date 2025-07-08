namespace InventoryControl.Application.UseCases.Item.Delete
{
    public interface IDeleteItemUseCase
    {
        public Task Execute(long itemId);
    }
}
