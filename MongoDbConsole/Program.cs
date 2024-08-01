using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbConsole.Model;

var mongodbUrl = "mongodb://localhost:27017";

var client = new MongoClient(mongodbUrl);
var database = client.GetDatabase("bank");

var accounts = database.GetCollection<Accounts>("account");


var document = new Accounts
{
    AccountId = "MD123",
    AccountHolder = "Reza Paidar",
    AccountType = "checking",
    Balance = 50352434,
};

accounts.InsertOne(document);
