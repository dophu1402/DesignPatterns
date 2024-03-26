namespace FactoryMethod.FactoryMethod.Products
{
    internal class Tigr : IAsset
    {
        public void SyncAssetData()
        {
            Console.WriteLine("Sync Tigr device from Tigr public project");
        }
    }
}
