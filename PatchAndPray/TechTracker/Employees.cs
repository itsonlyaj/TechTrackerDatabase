using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Employees
{
    [BsonId]
    public ObjectId _id { get; set; } = ObjectId.GenerateNewId();
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public Address address { get; set; } = new Address();
    public string PasswordHash { get; set; } = "";
    public string EmployeeRole { get; set; } = "";   
}

public class Address
{
    public string Street { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string ZipCode { get; set; } = "";
}