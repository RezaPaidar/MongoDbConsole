using MongoDB.Bson;
using MongoDB.Driver;

var mongodbUrl = "mongodb://<username>:<password>@<hostname>:<port>/<database>?<options>";

var client = new MongoClient(mongodbUrl);
var dbList = client.ListDatabaseNames().ToList();

Console.WriteLine("This list of database on this server is: ");
foreach (var db in dbList)
{
    Console.WriteLine(db);
}


var document = new BsonDocument
{
    {"accountId","MD123"},
    {"acountHolder","Reza Paidar"},
    {"acountType","checking"},
    {"balance","50352434"}
};