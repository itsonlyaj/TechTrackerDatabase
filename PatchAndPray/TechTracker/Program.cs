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

        // MongoDB connection string with credentials   
             
        const string connectionString = "mongodb+srv://db_woodwarda1:AJWoods-AUG!2300@cluster.vkiam1i.mongodb.net/?appName=Cluster";
        var client = new MongoClient(connectionString);

        // Access the "TechTracker" database and its collections

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

        // Inserts a single customer into the Customers collection and prints the assigned ID.

        // var oneCustomer = new Customer
        // {
        //     FirstName = "Tobias",
        //     LastName = "Doe",
        //     Email = "tobias.doe@gmail.com",
        //     Phone = "213-442-3210",
        //     CreationDate = DateOnly.FromDateTime(DateTime.Now)
        // };

        // customers.InsertOne(oneCustomer);
        // Console.WriteLine($"Customer {oneCustomer.FirstName} {oneCustomer.LastName} added with ID: {oneCustomer._id} \n");

        // Inserts multiple customers into the Customers collection and prints their assigned IDs.

        // var addManyCustomers = new List<Customer>
        // {
        //     new Customer
        //     {
        //         FirstName = "William",
        //         LastName = "Afton",
        //         Email = "william.afton@gmail.com",
        //         Phone = "846-103-4935",
        //         CreationDate = DateOnly.FromDateTime(DateTime.Now)
        //     },
        //     new Customer
        //     {
        //         FirstName = "Michael",
        //         LastName = "Afton",
        //         Email = "michael.afton@gmail.com",
        //         Phone = "846-453-0945",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2023, 5, 1))
        //     },
        //     new Customer
        //     {
        //         FirstName = "Richard",
        //         LastName = "Anglon",
        //         Email = "richie434092@outlook.com",
        //         Phone = "900-103-4935",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2024, 10, 10))
        //     },
        //     new Customer
        //     {
        //         FirstName = "Emily",
        //         LastName = "Smith",
        //         Email = "emilysmith2002@yahoo.com",
        //         Phone = "278-103-3024",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2026, 4, 20))
        //     },
        //     new Customer
        //     {
        //         FirstName = "David",
        //         LastName = "Johnson",
        //         Email = "davidjohn@outlook,com",
        //         Phone = "490-204-1003",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2025, 7, 15))
        //     },
        //     new Customer 
        //     {
        //         FirstName = "Sarah",
        //         LastName = "Miller",
        //         Email = "smiller@gmail.com",
        //         Phone = "846-191-7342",
        //         CreationDate = DateOnly.FromDateTime(DateTime.Now)
        //     },
        //     new Customer 
        //     {
        //         FirstName = "James",
        //         LastName = "Wilson",
        //         Email = "james.wilson@gmail.com",
        //         Phone = "846-343-4904",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2023, 2, 28))
        //     },
        //     new Customer 
        //     {
        //         FirstName = "Olivia",
        //         LastName = "Davis",
        //         Email = "OliviaLovesBTS@yahoo.com",
        //         Phone = "590-205-2984",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2024, 8, 5))
        //     },
        //     new Customer{
        //         FirstName = "Daniel",
        //         LastName = "Garcia",
        //         Email = "garciadan@yahoo.com",
        //         Phone = "864-783-2988",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2025, 11, 30))
        //     },
        //     new Customer
        //     {
        //         FirstName = "Matthew",
        //         LastName = "Carter",
        //         Email = "ILoveMHA@gmail.com",
        //         Phone = "999-444-4920",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2026, 1, 10))
        //     },
        //     new Customer
        //     {
        //         FirstName = "Tanner",
        //         LastName = "Davis",
        //         Email = "PeaShooterFromPVZ@outlook.com",
        //         Phone = "390-124-3904",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2026, 3, 15))
        //     },
        //     new Customer
        //     {
        //         FirstName = "Sophia",
        //         LastName = "Martinez",
        //         Email = "sophiamartinez@gmail.com",
        //         Phone = "555-123-4567",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2025, 6, 20))
        //     },
        //     new Customer
        //     {
        //         FirstName = "Andrew",
        //         LastName = "Anderson",
        //         Email = "andrew.anderson@gmail.com",
        //         Phone = "846-678-9012",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2024, 9, 25))
        //     },
        //     new Customer
        //     {
        //         FirstName = "Isabella",
        //         LastName = "Taylor",
        //         Email = "isabellataylor676@outlook.com",
        //         Phone = "534-232-4534",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2025, 10, 15))
        //     },
        //     new Customer
        //     {
        //         FirstName = "Joseph",
        //         LastName = "Thomas",
        //         Email = "joesbarbaquefootmasage@gmail.com",
        //         Phone = "893-156-1234",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2025, 11, 20))

        //     },
        //     new Customer
        //     {
        //         FirstName = "Mia",
        //         LastName = "Harris",
        //         Email = "harrism1@etsu.edu",
        //         Phone = "309-398-1045",
        //         CreationDate = DateOnly.FromDateTime(DateTime.Now)
        //     },
        //     new Customer
        //     {
        //         FirstName = "Christopher",
        //         LastName = "Clark",
        //         Email = "clarkc73@etsu.edu",
        //         Phone = "846-191-7342",
        //         CreationDate = DateOnly.FromDateTime(DateTime.Now)
        //     },
        //     new Customer
        //     {
        //         FirstName = "Ava",
        //         LastName = "Lewis",
        //         Email = "lewisav5@etsu.edu",
        //         Phone = "882-145-5982",
        //         CreationDate = DateOnly.FromDateTime(DateTime.Now)
        //     },
        //     new Customer
        //     {
        //         FirstName = "Ethan",
        //         LastName = "Winters",
        //         Email = "winterset@gmail.com",
        //         Phone = "290-783-4444",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2024, 12, 5))
        //     },
        //     new Customer
        //     {
        //         FirstName = "Tony",
        //         LastName = "Soprano",
        //         Email = "gabagool@yahoo.com",
        //         Phone = "946-678-9012",
        //         CreationDate = DateOnly.FromDateTime(DateTime.Now)
        //     },
        //     new Customer
        //     {
        //         FirstName = "Christopher",
        //         LastName = "Moltisanti",
        //         Email = "moltisantic@yahoo.com",
        //         Phone = "842-191-7935",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2022, 4, 17))
        //     },
        //     new Customer
        //     {
        //         FirstName = "Paulie",
        //         LastName = "Gualtieri",
        //         Email = "WatchItChrissy@gmail.com",
        //         Phone = "289-233-9801",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2023, 8, 10))
        //     },
        //     new Customer
        //     {
        //         FirstName = "Silvio",
        //         LastName = "Dante",
        //         Email = "JustAsIThoughIWasOutTheyPullMeBackIn@yahoo.com",
        //         Phone = "392-190-4920",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2024, 10, 23))
        //     },
        //     new Customer
        //     {
        //         FirstName = "Carmela",
        //         LastName = "Soprano",
        //         Email = "IHateMyHusband333@yahoo.com",
        //         Phone = "846-678-9012",
        //         CreationDate = DateOnly.FromDateTime(new DateTime(2026, 4, 22))
        //     }
        // };

        // customers.InsertMany(addManyCustomers);
        // Console.WriteLine("Customers added: \n");
        // foreach (var customer in addManyCustomers)
        // {
        //     Console.WriteLine($"{customer.FirstName} {customer.LastName} added with ID: {customer._id}");
        // }

        // Inserts a single device into the Devices collection and prints the assigned ID.

        // var oneDevice = new Devices
        // {
        //     CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdbf"), // ID of an existing customer in the Customers collection
        //     Brand = "Apple",
        //     Model = "iPhone 13 Pro Max",
        //     SerialNumber = "SN8948384893",
        //     UnderWarranty = true
        // };

        // devices.InsertOne(oneDevice);
        // Console.WriteLine($"Device {oneDevice.Brand} {oneDevice.Model} added with ID: {oneDevice._id} \n");

        // // Inserts multiple devices into the Devices collection and prints their assigned IDs.

        // var manyDevices = new List<Devices>
        // {
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdbf"), 
        //         Brand = "Samsung",
        //         Model = "Galaxy S21 Ultra",
        //         SerialNumber = "SN1234567890",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdbf"),
        //         Brand = "Google",
        //         Model = "Pixel 6 Pro",
        //         SerialNumber = "SN0987654321",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdbf"), 
        //         Brand = "OnePlus",
        //         Model = "9 Pro",
        //         SerialNumber = "SN5678901234",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69e57924403a5b0cd088eb24"),
        //         Brand = "Apple",
        //         Model = "iPhone 14 Pro",
        //         SerialNumber = "SN1000000001",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69e57ae78d519142231a1320"),
        //         Brand = "Samsung",
        //         Model = "Galaxy Z Fold 4",
        //         SerialNumber = "SN1000000002",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69e57cfa0836e782c647abfb"),
        //         Brand = "Google",
        //         Model = "Pixel 7",
        //         SerialNumber = "SN1000000003",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69e57cfa0836e782c647abfc"),
        //         Brand = "OnePlus",
        //         Model = "11",
        //         SerialNumber = "SN1000000004",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69e57cfa0836e782c647abfd"),
        //         Brand = "Motorola",
        //         Model = "Edge+",
        //         SerialNumber = "SN1000000005",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69e57cfa0836e782c647abfa"),
        //         Brand = "Sony",
        //         Model = "Xperia 1 V",
        //         SerialNumber = "SN1000000006",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea4ba4ec4b8282cdaebd65"),
        //         Brand = "Apple",
        //         Model = "iPhone 13",
        //         SerialNumber = "SN1000000007",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc0db704947f852bdaf"),
        //         Brand = "Samsung",
        //         Model = "Galaxy S22",
        //         SerialNumber = "SN1000000008",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdb0"),
        //         Brand = "Google",
        //         Model = "Pixel 6a",
        //         SerialNumber = "SN1000000009",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdb1"),
        //         Brand = "OnePlus",
        //         Model = "Nord N20",
        //         SerialNumber = "SN1000000010",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdb2"),
        //         Brand = "Apple",
        //         Model = "iPhone SE (2022)",
        //         SerialNumber = "SN1000000011",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdb3"),
        //         Brand = "Samsung",
        //         Model = "Galaxy A53",
        //         SerialNumber = "SN1000000012",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdb4"),
        //         Brand = "Google",
        //         Model = "Pixel 5",
        //         SerialNumber = "SN1000000013",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdb5"),
        //         Brand = "Sony",
        //         Model = "Xperia 5 IV",
        //         SerialNumber = "SN1000000014",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdb6"),
        //         Brand = "Motorola",
        //         Model = "Moto G Power",
        //         SerialNumber = "SN1000000015",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdb7"),
        //         Brand = "Apple",
        //         Model = "iPhone 12 Pro Max",
        //         SerialNumber = "SN1000000016",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdb8"),
        //         Brand = "Samsung",
        //         Model = "Galaxy Note 20",
        //         SerialNumber = "SN1000000017",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdb9"),
        //         Brand = "Google",
        //         Model = "Pixel 4 XL",
        //         SerialNumber = "SN1000000018",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdba"),
        //         Brand = "OnePlus",
        //         Model = "8T",
        //         SerialNumber = "SN1000000019",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdbb"),
        //         Brand = "Apple",
        //         Model = "iPhone 11",
        //         SerialNumber = "SN1000000020",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdbc"),
        //         Brand = "Samsung",
        //         Model = "Galaxy S20 FE",
        //         SerialNumber = "SN1000000021",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdbd"),
        //         Brand = "Google",
        //         Model = "Pixel 3a",
        //         SerialNumber = "SN1000000022",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdbe"),
        //         Brand = "Sony",
        //         Model = "Xperia 10 III",
        //         SerialNumber = "SN1000000023",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdbf"),
        //         Brand = "Apple",
        //         Model = "iPhone 15",
        //         SerialNumber = "SN1000000024",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdc0"),
        //         Brand = "Samsung",
        //         Model = "Galaxy S23",
        //         SerialNumber = "SN1000000025",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdc1"),
        //         Brand = "Google",
        //         Model = "Pixel 8",
        //         SerialNumber = "SN1000000026",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdc2"),
        //         Brand = "OnePlus",
        //         Model = "12",
        //         SerialNumber = "SN1000000027",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdc3"),
        //         Brand = "Apple",
        //         Model = "iPhone XR",
        //         SerialNumber = "SN1000000028",
        //         UnderWarranty = true
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdc4"),
        //         Brand = "Samsung",
        //         Model = "Galaxy A14",
        //         SerialNumber = "SN1000000029",
        //         UnderWarranty = false
        //     },
        //     new Devices
        //     {
        //         CustomerId = ObjectId.Parse("69ea6bc1db704947f852bdc5"),
        //         Brand = "Google",
        //         Model = "Pixel 2",
        //         SerialNumber = "SN1000000030",
        //         UnderWarranty = true
        //     }
        // };

        // devices.InsertMany(manyDevices);
        // Console.WriteLine("Devices added: \n");
        // foreach (var device in manyDevices)
        // {
        //     Console.WriteLine($"{device.Brand} {device.Model} added with ID: {device._id}");
        // }

        // Inserts a single employee into the Employees collection and prints the assigned ID.

        // var addEmployee = new Employees
        // {
        //     FirstName = "AJ",
        //     LastName = "Woodward",
        //     Email = "ajwoodward@techtracker.com",
        //     PhoneNumber = "846-191-7342",
        //     address = new Address   // Nested address object with street, city, state, and zip code
        //     {
        //         Street = "199 Main St",
        //         City = "Johnson City",
        //         State = "TN",
        //         ZipCode = "37601"
        //     },
        //     PasswordHash = "teST&878@373",
        //     EmployeeRole = "Manager"
        // };

        // employees.InsertOne(addEmployee);
        // Console.WriteLine($"Employee {addEmployee.FirstName} {addEmployee.LastName} added with ID: {addEmployee._id} \n");

        // Adds the list of employees to the database.

        // var collaboratorsPlusProfessor = new List<Employees>
        // {
        //     new Employees
        //     {
        //         FirstName = "Vanay",
        //         LastName = "Rowell",
        //         Email = "vanayrowell@techtracker.com",
        //         PhoneNumber = "864-134-4472",
        //         address = new Address
        //         {
        //             Street = "123 Elm St",
        //             City = "Johnson City",
        //             State = "TN",
        //             ZipCode = "37601"
        //         },
        //         PasswordHash = "vANAY&878@373",
        //         EmployeeRole = "Technician"
        //     },
        //     new Employees
        //     {
        //         FirstName = "Luke",
        //         LastName = "Mason",
        //         Email = "lukemason@techtracker.com",
        //         PhoneNumber = "864-134-4473",
        //         address = new Address
        //         {
        //             Street = "456 Oak Ave",
        //             City = "Johnson City",
        //             State = "TN",
        //             ZipCode = "37601"
        //         },
        //         PasswordHash = "lUKE&878@373",
        //         EmployeeRole = "Supervisor"
        //     },
        //     new Employees
        //     {
        //         FirstName = "Alex",
        //         LastName = "Gillespie",
        //         Email = "alexgillespie@techtracker.com",
        //         PhoneNumber = "392-437-1083",
        //         address = new Address
        //         {
        //             Street = "290 Park Way Dr",
        //             City = "Kingsport",
        //             State = "TN",
        //             ZipCode = "37662"
        //         },
        //         PasswordHash = "AL3XG19^732",
        //         EmployeeRole = "Technician"
        //     },
        //     new Employees
        //     {
        //         FirstName = "Matthew",
        //         LastName = "Desjardins",
        //         Email = "notmatthewdesjardins@techtracker.com",
        //         PhoneNumber = "892-323-9032",
        //         address = new Address
        //         {
        //             Street = "900 Forest Rd",
        //             City = "Kingsport",
        //             State = "TN",
        //             ZipCode = "37660"
        //         },
        //         PasswordHash = "Yu)&536Y839$%@-(2^*&)",
        //         EmployeeRole = "CEO"
        //     }
        // };

        // Prints out employees names, IDs, emails, and roles.

        // employees.InsertMany(collaboratorsPlusProfessor);
        // Console.WriteLine("Employees Inserted: \n");
        // foreach (var employee in collaboratorsPlusProfessor)
        // {
        //     Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}, ID: {employee._id}, Email: {employee.Email}, Role: {employee.EmployeeRole}");
        // }

        var randomEmployees = new List<Employees>
        {
            new Employees
            {
                FirstName = "Harold",
                LastName = "Douglas",
                Email = "harold343@techtracker.com",
                PhoneNumber = "483-111-2003",
                address = new Address
                {
                    Street = "934 Pine Dr",
                    City = "Bristol",
                    State = "TN",
                    ZipCode = "24201"
                },
                PasswordHash = "H783*#6Hg&2",
                EmployeeRole = "Technician"
            },
            new Employees
            {
                FirstName = "Landon",
                LastName = "Reeves",
                Email = "lreeves@techtracker.com",
                PhoneNumber = "423-555-1011",
                address = new Address
                {
                    Street = "120 Maple Ridge Rd",
                    City = "Johnson City",
                    State = "TN",
                    ZipCode = "37601"
                },
                PasswordHash = "P@ss92!LmA",
                EmployeeRole = "Marketing"
            },
            new Employees
            {
                FirstName = "Samantha",
                LastName = "Cole",
                Email = "scole@techtracker.com",
                PhoneNumber = "423-555-1012",
                address = new Address
                {
                Street = "88 Willow Bend Ln",
                City = "Kingsport",
                State = "TN",
                ZipCode = "37660"
            },
            PasswordHash = "Tg#44Lp9$Q",
            EmployeeRole = "Sales Associate"
            },
            new Employees
            {
                FirstName = "Marcus",
                LastName = "Hendrix",
                Email = "mhendrix@techtracker.com",
                PhoneNumber = "423-555-1013",
                address = new Address
                {
                    Street = "402 Cedar Hill Dr",
                    City = "Bristol",
                    State = "TN",
                    ZipCode = "24201"
                },
                PasswordHash = "Zp!82@Qw7H",
                EmployeeRole = "Customer Support"
            },
            new Employees
            {
                FirstName = "Alyssa",
                LastName = "Turner",
                Email = "aturner@techtracker.com",
                PhoneNumber = "423-555-1014",
                address = new Address
                {
                    Street = "19 Oak Crest Ct",
                    City = "Johnson City",
                    State = "TN",
                    ZipCode = "37604"
                },
                PasswordHash = "R#9fT2!Lm8",
                EmployeeRole = "Supervisor"
            },
            new Employees
            {
                FirstName = "Evan",
                LastName = "Mitchell",
                Email = "emitchell@techtracker.com",
                PhoneNumber = "423-555-1015",
                address = new Address
                {
                    Street = "501 Ridgeview Dr",
                    City = "Elizabethton",
                    State = "TN",
                    ZipCode = "37643"
                },
                PasswordHash = "Kp$33!Ht7B",
                EmployeeRole = "Technician"
            },
            new Employees
            {
                FirstName = "Jenna",
                LastName = "Fowler",
                Email = "jfowler@techtracker.com",
                PhoneNumber = "423-555-1016",
                address = new Address
                {
                    Street = "77 Birchwood Ln",
                    City = "Jonesborough",
                    State = "TN",
                    ZipCode = "37659"
                },
                PasswordHash = "M!8tQ#2LpX",
                EmployeeRole = "Marketing"
            },
            new Employees
            {
                FirstName = "Caleb",
                LastName = "Owens",
                Email = "cowens@techtracker.com",
                PhoneNumber = "423-555-1017",
                address = new Address
                {
                    Street = "310 Meadowbrook Dr",
                    City = "Kingsport",
                    State = "TN",
                    ZipCode = "37663"
                },
                PasswordHash = "S@7pL!9QwF",
                EmployeeRole = "Sales Associate"
            },
            new Employees
            {
                FirstName = "Rachel",
                LastName = "Benson",
                Email = "rbenson@techtracker.com",
                PhoneNumber = "423-555-1018",
                address = new Address
                {
                    Street = "14 Sycamore St",
                    City = "Johnson City",
                    State = "TN",
                    ZipCode = "37615"
                },
                PasswordHash = "H#4tP!8LmC",
                EmployeeRole = "Customer Support"
            },
            new Employees
            {
                FirstName = "Derrick",
                LastName = "Shaw",
                Email = "dshaw@techtracker.com",
                PhoneNumber = "423-555-1019",
                address = new Address
                {
                    Street = "221 Highland Ridge Rd",
                    City = "Bristol",
                    State = "TN",
                    ZipCode = "24202"
                },
                PasswordHash = "Qp!6T#9LmV",
                EmployeeRole = "Supervisor"
            },
            new Employees
            {
                FirstName = "Megan",
                LastName = "Harris",
                Email = "mharris@techtracker.com",
                PhoneNumber = "423-555-1020",
                address = new Address
                {
                    Street = "900 Forest View Dr",
                    City = "Elizabethton",
                    State = "TN",
                    ZipCode = "37643"
                },
                PasswordHash = "Lp#3Q!7HtB",
                EmployeeRole = "Technician"
            },
            new Employees
            {
                FirstName = "Tyler",
                LastName = "Grant",
                Email = "tgrant@techtracker.com",
                PhoneNumber = "423-555-1021",
                address = new Address
                {
                    Street = "65 Riverbend Way",
                    City = "Jonesborough",
                    State = "TN",
                    ZipCode = "37659"
                },
                PasswordHash = "W!9tP#4LmS",
                EmployeeRole = "Marketing"
            },
            new Employees
            {
                FirstName = "Hailey",
                LastName = "Stevens",
                Email = "hstevens@techtracker.com",
                PhoneNumber = "423-555-1022",
                address = new Address
                {
                    Street = "300 Brookside Dr",
                    City = "Kingsport",
                    State = "TN",
                    ZipCode = "37664"
                },
                PasswordHash = "B#2tQ!8LpM",
                EmployeeRole = "Sales Associate"
            },
            new Employees
            {
                FirstName = "Jordan",
                LastName = "Parker",
                Email = "jparker@techtracker.com",
                PhoneNumber = "423-555-1023",
                address = new Address
                {
                    Street = "48 Chestnut Hill Rd",
                    City = "Johnson City",
                    State = "TN",
                    ZipCode = "37601"
                },
                PasswordHash = "T!7pL#3QwH",
                EmployeeRole = "Customer Support"
            },
            new Employees
            {
                FirstName = "Brianna",
                LastName = "Knight",
                Email = "bknight@techtracker.com",
                PhoneNumber = "423-555-1024",
                address = new Address
                {
                    Street = "12 Meadow Lane",
                    City = "Bristol",
                    State = "TN",
                    ZipCode = "24201"
                },
                PasswordHash = "N#5tQ!9LpA",
                EmployeeRole = "Supervisor"
            }
        };

        employees.InsertMany(randomEmployees);
        Console.WriteLine("Employees Inserted: \n");
        foreach (var employee in randomEmployees)
        {
            Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}, ID: {employee._id}, Email: {employee.Email}, Role: {employee.EmployeeRole}");
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
    public bool underWarranty { get; set; }
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