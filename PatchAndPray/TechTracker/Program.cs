using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using DotNetEnv;

namespace TechTracker;

class Program
{
    static void Main(string[] args)
    {
        Env.Load();
        
        const string connectionString = "YOUR MONGO URI";
        var client = new MongoClient(connectionString);

        var db = client.GetDatabase("TechTracker");
        var customers = db.GetCollection<Customer>("Customers");

        var db2 = client.GetDatabase("TechTracker");
        var devices = db2.GetCollection<Devices>("Devices");

        var db3 = client.GetDatabase("TechTracker");
        var employees = db3.GetCollection<Employees>("Employees");

        var db4 = client.GetDatabase("TechTracker");
        var repairOrders = db4.GetCollection<RepairOrders>("RepairOrders");

        var db5 = client.GetDatabase("TechTracker");
        var inventory = db5.GetCollection<Inventory>("Inventory");

        var db6 = client.GetDatabase("TechTracker");
        var transactions = db6.GetCollection<Transactions>("Transactions");

        // var customer = new Customer
        // {
        //     FirstName = "AJ",
        //     LastName = "Woodward",
        //     Email = "ajwoodward@outlook.com",
        //     Phone = "763-109-3920",
        //     CreationDate = DateOnly.FromDateTime(new DateTime(2023, 3, 3))
        // };

        // customers.InsertOne(customer);

        // var filter = Builders<Customer>.Filter.Eq(c => c.FirstName, "AJ");
        // var aj = customers.Find(filter).FirstOrDefault();
        // if (aj != null)
        // {
        //      Console.WriteLine($"Found customer: {aj.FirstName} {aj.LastName}");
        // }
        // else
        // {
        //      Console.WriteLine("Customer not found.");
        // }

        // var device = new Devices
        // {
        //     CustomerId = ObjectId.Parse("69e57924403a5b0cd088eb24"), // Replace with actual CustomerId
        //     Brand = "Apple",
        //     Model = "iPhone 13",
        //     SerialNumber = "SN123456789"
        // };

        // devices.InsertOne(device);
        // Console.WriteLine("Device inserted successfully.");

        // var insertManyDevices = new List<Devices>
        // {
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69e57ae78d519142231a1320"), // Replace with actual CustomerId
        //         Brand = "Samsung",
        //         Model = "Galaxy S21",
        //         SerialNumber = "SN5834394857"
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69e57cfa0836e782c647abfa"), // Replace with actual CustomerId
        //         Brand = "Google",
        //         Model = "Pixel 6",
        //         SerialNumber = "SN9876543210"
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69e57cfa0836e782c647abfb"), // Replace with actual CustomerId
        //         Brand = "Microsoft",
        //         Model = "Surface Pro 7",
        //         SerialNumber = "SN1122334455"
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69e57cfa0836e782c647abfc"), // Replace with actual CustomerId
        //         Brand = "Dell",
        //         Model = "XPS 13",
        //         SerialNumber = "SN0057385346"
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69e57cfa0836e782c647abfd"), // Replace with actual CustomerId
        //         Brand = "HP",
        //         Model = "Spectre x360",
        //         SerialNumber = "SN9108438425"
        //     }
        // };

        // devices.InsertMany(insertManyDevices);
        // Console.WriteLine("Multiple devices inserted successfully.");

        // var d = new Devices
        // {
        //     CustomerId = ObjectId.Parse("69e57ae78d519142231a1320"), // Replace with actual CustomerId
        //     Brand = "Lenovo",
        //     Model = "ThinkPad X1 Carbon",
        //     SerialNumber = "SN8004589424"
        // };

        // devices.InsertOne(d);
        // Console.WriteLine("Device inserted successfully.");

        
        // var employee = new Employees
        // {
        //     FirstName = "John",
        //     LastName = "Doe",
        //     Email = "johndoe@example.com",
        //     PhoneNumber = "555-1234",
        //     address = new Address
        //     {
        //         Street = "123 Main St",
        //         City = "Anytown",
        //         State = "CA",
        //         ZipCode = "12345"
        //     },
        //     PasswordHash = "johndoe!123YZ",
        //     EmployeeRole = "Technician"
        // };

        // employees.InsertOne(employee);
        // Console.WriteLine("Employee inserted successfully.");

        // var listOfEmployees = new List<Employees>
        // {
        //     new Employees
        //     {
        //         FirstName = "Janice",
        //         LastName = "Soprano",
        //         Email = "janicesoprano@gmail.com",
        //         PhoneNumber = "555-544-2094",
        //         address = new Address
        //         {
        //             Street = "456 Oak Ave",
        //             City = "Newark",
        //             State = "NJ",
        //             ZipCode = "67890"
        //         },
        //         PasswordHash = "janJH)92!",
        //         EmployeeRole = "Manager"
        //     },
        //     new Employees
        //     {
        //         FirstName = "Tony",
        //         LastName = "Stark",
        //         Email = "tonystark@gmail.com",
        //         PhoneNumber = "693-555-1234",
        //         address = new Address
        //         {
        //             Street = "789 Pine Rd",
        //             City = "Los Angeles",
        //             State = "CA",
        //             ZipCode = "90210"
        //         },
        //         PasswordHash = "tonyStark!123YZ",
        //         EmployeeRole = "Technician"
        //     },
        //     new Employees
        //     {
        //         FirstName = "Bruce",
        //         LastName = "Wayne",
        //         Email = "brucewayne@outlook.com",
        //         PhoneNumber = "555-987-6543",
        //         address = new Address
        //         {
        //             Street = "321 Elm St",
        //             City = "Queens",
        //             State = "NY",
        //             ZipCode = "54321"
        //         },
        //         PasswordHash = "bruceWNE452!",
        //         EmployeeRole = "Customer Service"
        //     },
        //     new Employees
        //     {
        //         FirstName = "Diana",
        //         LastName = "Prince",
        //         Email = "dianaprince@gmail.com",
        //         PhoneNumber = "555-246-8100",
        //         address = new Address
        //         {
        //             Street = "654 Maple Ave",
        //             City = "Chicago",
        //             State = "IL",
        //             ZipCode = "60601"
        //         },
        //         PasswordHash = "B8760<k(!@#",
        //         EmployeeRole = "Sales Associate"
        //     }
        // };

        // listOfEmployees.ForEach(e => employees.InsertOne(e));
        // Console.WriteLine("Multiple employees inserted successfully.");

        // employees.InsertMany(listOfEmployees);
        // Console.WriteLine("Multiple employees inserted successfully.");

        
        // var customer = new Customer
        // {
        //     FirstName = "John",
        //     LastName = "Doe",
        //     Email = "johndoe@example.com",
        //     Phone = "555-1234",
        //     CreationDate = DateOnly.FromDateTime(DateTime.Now)
        // };

        // customers.InsertOne(customer);
        // Console.WriteLine("Customer inserted successfully.");

        // var repairOrder = new RepairOrders
        // {
        //     CustomerId = ObjectId.Parse("69e57924403a5b0cd088eb24"), // Replace with actual CustomerId
        //     DeviceId = ObjectId.Parse("69e661998c518d075aef0561"), // Replace with actual DeviceId
        //     AssignedEmployeeId = new List<ObjectId> { ObjectId.Parse("69e66e34c713ec6e18a3d27f"), ObjectId.Parse("69e6711fdc7fc5ee11d6d650") }, // Replace with actual EmployeeIds
        //     Status = "In Progress",
        //     HoursBillable = 2,
        //     PartsUsed = "Screen, Battery",
        //     Notes = "Customer reported screen flickering and battery draining quickly.",
        //     CreationDate = DateTime.Now,
        //     UpdateDate = DateTime.Now,
        //     CompletionDate = DateTime.Now.AddDays(3) // Set completion date to 3 days from now
        // };
         
        //repairOrders.InsertOne(repairOrder);

        // var manyRepairOrders = new List<RepairOrders>
        // {
        //     new RepairOrders
        //     {
        //         CustomerId = ObjectId.Parse("69e57cfa0836e782c647abfc"), // Replace with actual CustomerId
        //         DeviceId = ObjectId.Parse("69e66445a362be3a0bfe9587"), // Replace with actual DeviceId
        //         AssignedEmployeeId = new List<ObjectId> { ObjectId.Parse("69e6711fdc7fc5ee11d6d651") }, // Replace with actual EmployeeIds
        //         Status = "Completed",
        //         HoursBillable = 3,
        //         PartsUsed = "Battery",
        //         Notes = "Replaced battery, device is now functioning properly.",
        //         CreationDate = DateTime.Now.AddDays(-10),
        //         UpdateDate = DateTime.Now.AddDays(-5),
        //         CompletionDate = DateTime.Now.AddDays(-5)
        //     },

        //     new RepairOrders
        //     {
        //         CustomerId = ObjectId.Parse("69e57cfa0836e782c647abfd"), // Replace with actual CustomerId
        //         DeviceId = ObjectId.Parse("69e66445a362be3a0bfe9588"), // Replace with actual DeviceId
        //         AssignedEmployeeId = new List<ObjectId> { ObjectId.Parse("69e6711fdc7fc5ee11d6d64f") }, // Replace with actual EmployeeIds
        //         Status = "In Progress",
        //         HoursBillable = 1,
        //         PartsUsed = "Screen",
        //         Notes = "Customer reported cracked screen, awaiting parts.",
        //         CreationDate = DateTime.Now.AddDays(-2),
        //         UpdateDate = DateTime.Now,
        //         CompletionDate = null // Not completed yet
        //     },

        //     new RepairOrders
        //     {
        //         CustomerId = ObjectId.Parse("69e57cfa0836e782c647abfe"), // Replace with actual CustomerId
        //         DeviceId = ObjectId.Parse("69e66445a362be3a0bfe9589"), // Replace with actual DeviceId
        //         AssignedEmployeeId = new List<ObjectId> { ObjectId.Parse("69e6711fdc7fc5ee11d6d650") }, // Replace with actual EmployeeIds
        //         Status = "Completed",
        //         HoursBillable = 4,
        //         PartsUsed = "Screen, Battery",
        //         Notes = "Replaced screen and battery, device is now functioning properly.",
        //         CreationDate = DateTime.Now.AddDays(-15),
        //         UpdateDate = DateTime.Now.AddDays(-10),
        //         CompletionDate = DateTime.Now.AddDays(-10)
        //     }
        // };

        // repairOrders.InsertMany(manyRepairOrders);

        // var inventoryItem = new Inventory
        // {
        //     PartName = "iPhone 13 Screen",
        //     PartLocation = "Aisle 3, Shelf B",
        //     Stock = 10,
        //     LowStockThreshold = 5,
        //     Cost = 199.99,
        //     CompatabilityTag = "iPhone 13"
        // };

        // inventory.InsertOne(inventoryItem);

        // var manyInventoryItems = new List<Inventory>
        // {
        //     new Inventory
        //     {
        //         PartName = "Samsung Galaxy S21 Battery",
        //         PartLocation = "Aisle 4, Shelf A",
        //         Stock = 15,
        //         LowStockThreshold = 5,
        //         Cost = 89.99,
        //         CompatabilityTag = "Samsung Galaxy S21"
        //     },
        //     new Inventory
        //     {
        //         PartName = "Google Pixel 6 Screen",
        //         PartLocation = "Aisle 5, Shelf C",
        //         Stock = 8,
        //         LowStockThreshold = 3,
        //         Cost = 149.99,
        //         CompatabilityTag = "Google Pixel 6"
        //     },
        //     new Inventory
        //     {
        //         PartName = "Microsoft Surface Pro 7 Battery",
        //         PartLocation = "Aisle 6, Shelf B",
        //         Stock = 12,
        //         LowStockThreshold = 4,
        //         Cost = 129.99,
        //         CompatabilityTag = "Microsoft Surface Pro 7"
        //     },
        //     new Inventory
        //     {
        //         PartName = "Dell XPS 13 Screen",
        //         PartLocation = "Aisle 7, Shelf A",
        //         Stock = 5,
        //         LowStockThreshold = 2,
        //         Cost = 179.99,
        //         CompatabilityTag = "Dell XPS 13"
        //     },
        //     new Inventory
        //     {
        //         PartName = "HP Spectre x360 Battery",
        //         PartLocation = "Aisle 8, Shelf C",
        //         Stock = 20,
        //         LowStockThreshold = 10,
        //         Cost = 109.99,
        //         CompatabilityTag = "HP Spectre x360"
        //     }
        // };

        // inventory.InsertMany(manyInventoryItems); 

        // var transaction = new Transactions
        // {
        //     OrderId = ObjectId.Parse("69e81dd9271df5d6cb27de78"), // Replace with actual OrderId
        //     Cost = 299.99,
        //     PaymentMethod = "Credit Card",
        //     Date = DateOnly.FromDateTime(DateTime.Now),
        //     Completed = true
        // };

        // transactions.InsertOne(transaction);

        // var manyTransactions = new List<Transactions>
        // {
        //     new Transactions
        //     {
        //         OrderId = ObjectId.Parse("69e81dd9271df5d6cb27de78"), // Replace with actual OrderId
        //         Cost = 299.99,
        //         PaymentMethod = "Credit Card",
        //         Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-1)),
        //         Completed = true
        //     },
        //     new Transactions
        //     {
        //         OrderId = ObjectId.Parse("69e81dd9271df5d6cb27de79"), // Replace with actual OrderId
        //         Cost = 149.99,
        //         PaymentMethod = "Cash",
        //         Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-2)),
        //         Completed = false
        //     },
        //     new Transactions
        //     {
        //         OrderId = ObjectId.Parse("69e81dd9271df5d6cb27de7a"), // Replace with actual OrderId
        //         Cost = 89.99,
        //         PaymentMethod = "Debit Card",
        //         Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-3)),
        //         Completed = true
        //     },
        //     new Transactions
        //     {
        //         OrderId = ObjectId.Parse("69e81dd9271df5d6cb27de7b"), // Replace with actual OrderId
        //         Cost = 199.99,
        //         PaymentMethod = "Credit Card",
        //         Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-4)),
        //         Completed = false
        //     },
        //     new Transactions
        //     {
        //         OrderId = ObjectId.Parse("69e81dd9271df5d6cb27de7c"), // Replace with actual OrderId
        //         Cost = 129.99,
        //         PaymentMethod = "Cash",
        //         Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-5)),
        //         Completed = true
        //     }
        // };
        // transactions.InsertMany(manyTransactions);

        var filterCompletedTransactions = Builders<Transactions>.Filter.Eq(t => t.Completed, true);
        var completedTransactions = transactions.Find(filterCompletedTransactions).ToList();
        Console.WriteLine("Completed Transactions:");
        foreach (var t in completedTransactions)    // Will loop through all transactions and print out the details of those that are marked as completed.
        {
            Console.WriteLine($"OrderId: {t.OrderId}, Cost: {t.Cost}, PaymentMethod: {t.PaymentMethod}, Date: {t.Date}");
        }

        var filterExpensiveTransactions = Builders<Transactions>.Filter.Gt(t => t.Cost, 150);
        var expensiveTransactions = transactions.Find(filterExpensiveTransactions).ToList();
        Console.WriteLine("Expensive Transactions:");
        foreach (var t in expensiveTransactions)    // Will loop through all transactions and print out the details of those that have a cost greater than $150.
        {
            Console.WriteLine($"OrderId: {t.OrderId}, Cost: {t.Cost}, PaymentMethod: {t.PaymentMethod}, Date: {t.Date}");
        }

        var allTransactions = transactions.Find(new BsonDocument()).ToList();
        Console.WriteLine("All Transactions:");
        foreach (var t in allTransactions)    // Will loop through all transactions and print out the details of each transaction, regardless of its completion status or cost.
        {
            Console.WriteLine($"OrderId: {t.OrderId}, Cost: {t.Cost}, PaymentMethod: {t.PaymentMethod}, Date: {t.Date}, Completed: {t.Completed}");
        }

        var filterTechnicianEmployees = Builders<Employees>.Filter.Eq(e => e.EmployeeRole, "Technician");
        var technicianEmployees = employees.Find(filterTechnicianEmployees).ToList();
        Console.WriteLine("Technician Employees:");
        foreach (var e in technicianEmployees)    // Will loop through all employees and print out the details of those whose role is "Technician".
        {
            Console.WriteLine($"ID: {e._id}, Name: {e.FirstName} {e.LastName}, Email: {e.Email}, Phone: {e.PhoneNumber}, Role: {e.EmployeeRole}");
        }

    } 
}

public class Customer
{
    [BsonId]
    public ObjectId _id { get; set; } = ObjectId.GenerateNewId();
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public DateOnly CreationDate { get; set; }
}

public class Devices
{
    [BsonId]
    public ObjectId _id { get; set; } = ObjectId.GenerateNewId();
    public ObjectId CustomerId { get; set; }
    public string Brand { get; set; } = "";
    public string Model { get; set; } = "";
    public string SerialNumber { get; set; } = "";
}

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

}

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
