using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class RepairOrders
{
    [BsonId]
    public ObjectId _id { get; set; } = ObjectId.GenerateNewId();
    public ObjectId CustomerId { get; set; }
    public ObjectId DeviceId { get; set; }
    public List<ObjectId> AssignedEmployeeId { get; set; } = new List<ObjectId>();
    public string Status { get; set; } = "";
    public int HoursBillable { get; set; }
    public string PartsUsed { get; set; } = "";
    public string Notes { get; set; } = "";
    public DateTime CreationDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime? CompletionDate { get; set; }
}