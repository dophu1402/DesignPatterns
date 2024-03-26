using FactoryMethod.FactoryMethod.Products;

namespace FactoryMethod.FactoryMethod
{
    public static class AssetFactoryMethod
    {
        public static IAsset CreateAsset(string type)
        {
            switch (type)
            {
                case "irec":
                    return new Irec();
                case "tigr":
                    return new Tigr();
                default:
                    return new Tigr();
            }
        }
    }
}
