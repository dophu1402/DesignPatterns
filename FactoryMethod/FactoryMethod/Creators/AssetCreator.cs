namespace FactoryMethod.FactoryMethod.Creators
{
    public abstract class AssetCreator
    {
        public abstract IAsset CreateAsset();
        public void SyncAssetDataOperation()
        {
            var asset = CreateAsset();
            asset.SyncAssetData();
        }
    }
}
