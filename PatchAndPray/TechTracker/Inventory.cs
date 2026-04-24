using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Inventory
{
    [BsonId]
    public ObjectId _id { get; set; } = ObjectId.GenerateNewId();
    public string PartName { get; set; } = "";
    public string PartLocation { get; set; } = "";
    public int Stock { get; set; }
    public int LowStockThreshold { get; set; }
    public double Cost { get; set; }
    public string CompatabilityTag { get; set; } = "";
    public string supplier { get; set; } = "";
}