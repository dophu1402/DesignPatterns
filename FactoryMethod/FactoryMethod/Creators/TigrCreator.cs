using FactoryMethod.FactoryMethod.Products;

namespace FactoryMethod.FactoryMethod.Creators
{
    internal class TigrCreator : AssetCreator
    {
        public override IAsset CreateAsset()
        {
            return new Tigr();
        }
    }
}
