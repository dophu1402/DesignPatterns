namespace FactoryMethod.FactoryMethod.Products
{
    internal class Irec : IAsset
    {
        public void SyncAssetData()
        {
            Console.WriteLine("Sync Irec data from Evident");
        }
    }
}
