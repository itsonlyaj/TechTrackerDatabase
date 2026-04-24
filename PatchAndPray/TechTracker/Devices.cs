using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Devices
{
    [BsonId]
    public ObjectId _id { get; set; } = ObjectId.GenerateNewId();
    public ObjectId CustomerId { get; set; }
    public string Brand { get; set; } = "";
    public string Model { get; set; } = "";
    public string SerialNumber { get; set; } = "";
    public bool underWarranty { get; set; }
}