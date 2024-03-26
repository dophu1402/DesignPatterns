using FactoryMethod.FactoryMethod;
using FactoryMethod.FactoryMethod.Creators;
using FactoryMethod.FactoryMethod.Products;


// using static factory method
/*
var tigr = AssetFactoryMethod.CreateAsset("tigr");
var irec = AssetFactoryMethod.CreateAsset("irec");
*/


// using Factory Method
var tigrCreator = new TigrCreator();
var tigr = tigrCreator.CreateAsset();

var irecCreator = new IrecCreator();
var irec = irecCreator.CreateAsset();

tigr.SyncAssetData();
irec.SyncAssetData();


var creator = new TigrCreator();
creator.CreateAsset();