using Microsoft.VisualBasic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

[BsonIgnoreExtraElements]
public class Customer
{
    [BsonId]
    public ObjectId _id { get; set; } = ObjectId.GenerateNewId();
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public DateTime CreationDate { get; set; }
}