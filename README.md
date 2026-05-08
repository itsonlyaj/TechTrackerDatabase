# TechTrackerDatabase

This program will add sample data sets to the TechTracker web application. Here is how you get this program connected with MongoDB

1. You will create a cluster for the database.

2. You will need to install the C# driver, so you'll be able to connect to the database. To do this, you go into your terminal and input dotnet add package MongoDB.Driver

3. Replace the connection string with your username and password. It will be shown like this in the connection string <db_username>:<db_password>

4. Go to the connection COPY ME.env file and replace the "" with your connection string, then the database name should be TechTracker.

5. Go to the Program.cs file and replace "Your_Connection_String" with your actual connection string.

6. Run all six of the db variables to create the collections.

7. Finally run all of the InsertOne() and InsertMany() statments in the database program.
