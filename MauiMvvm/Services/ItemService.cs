namespace MauiMvvm.Services
{
    public class ItemService
    {
        ICrudIdService<Item> crudIdService;

        public ItemService(ICrudIdService<Item> crudIdService)
        {
            this.crudIdService = crudIdService;
        }
    }
}
