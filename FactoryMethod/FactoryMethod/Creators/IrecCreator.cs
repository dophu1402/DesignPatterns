using FactoryMethod.FactoryMethod.Products;

namespace FactoryMethod.FactoryMethod.Creators
{
    internal class IrecCreator : AssetCreator
    {
        public override IAsset CreateAsset()
        {
            return new Irec();
        }
    }
}
