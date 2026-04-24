using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Transactions
{
    [BsonId]
    public ObjectId _id { get; set; } = ObjectId.GenerateNewId();
    public ObjectId OrderId { get; set; }
    public double Cost { get; set; }
    public string PaymentMethod { get; set; } = "";
    public DateOnly Date { get; set; }
    public bool Completed { get; set; }
}