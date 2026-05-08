using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

[BsonIgnoreExtraElements]
public class Transactions
{
    [BsonId]
    public ObjectId _id { get; set; }
    public ObjectId OrderId { get; set; }
    public double Cost { get; set; }
    public string PaymentMethod { get; set; } = "";
    public DateTime Date { get; set; }
    public bool Completed { get; set; }
}