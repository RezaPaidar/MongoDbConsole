using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbConsole.Model;

var mongodbUrl = "mongodb://localhost:27017";

var client = new MongoClient(mongodbUrl);
var database = client.GetDatabase("bank");

var accounts = database.GetCollection<Accounts>("account");


//var document = new Accounts
//{
//    AccountId = "MD123",
//    AccountHolder = "Reza Paidar",
//    AccountType = "checking",
//    Balance = 50352434,
//};

//accounts.InsertOne(document);


//var AcoountA = new Accounts
//{
//    AccountId = "MD124",
//    AccountHolder = "Sina Dardar",
//    AccountType = "Checking",
//    Balance = 1200005,

//};
//var AcoountB = new Accounts
//{
//    AccountId = "MD125",
//    AccountHolder = "Aida Sharifi",
//    AccountType = "Checking",
//    Balance = 1800002,

//};

//accounts.InsertMany(new List<Accounts>() { AcoountA, AcoountB });

//var account = accounts.Find(x=>x.AccountId == "MD123").FirstOrDefault();

//Console.WriteLine(account.AccountHolder);

var accs = accounts.Find(x=>x.AccountType == "Checking")
    .SortByDescending(x=>x.Balance).Limit(3).ToList();

foreach (var acc in accs)
{
    Console.WriteLine(acc.AccountHolder);
}