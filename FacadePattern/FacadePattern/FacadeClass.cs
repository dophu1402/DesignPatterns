using FacadePattern.FacadePattern.Services;

namespace FacadePattern.FacadePattern
{
    public class FacadeClass
    {
        private AssetApplicationService _assetApplicationService;
        private InventoryService _inventoryService;
        private NotificationService _notificationService;

        // can use Dependency injection here
        public FacadeClass()
        {
            _assetApplicationService = new AssetApplicationService();
            _inventoryService = new InventoryService();
            _notificationService = new NotificationService();
        }

        public void EditApplication()
        {
            Console.WriteLine("Edit application:");
            _assetApplicationService.Edit();
            _notificationService.SendNotificationToUser();
            Console.WriteLine("---");
        }

        public void ApproveApplication()
        {
            Console.WriteLine("Approve application:");
            _assetApplicationService.Approve();
            _inventoryService.AddAssetToInventory();
            _notificationService.SendNotificationToUser();
            Console.WriteLine("---");
        }
    }
}
