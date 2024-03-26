namespace FacadePattern.FacadePattern.Services
{
    public class AssetApplicationService
    {
        public void Approve()
        {
            Console.WriteLine("AssetApplicationService: Change status of application to Approved");
        }

        public void Edit()
        {
            Console.WriteLine("AssetApplicationService: Edit Application information");
        }
    }
}
