using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbConsole.Model
{
    public sealed class Accounts
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("account_id")]
        public string AccountId { get; set; } = string.Empty;

        [BsonElement("account_holder")]
        public string AccountHolder { get; set; } = string.Empty;

        [BsonElement("account_type")]
        public string AccountType { get; set; } = string.Empty;

        [BsonElement("balance")]
        public string Balance { get; set; }

        [BsonElement("transfer_complete")]
        public string[] TransfersCompleted { get; set; } = Array.Empty<string>();
    }
}
