// See https://aka.ms/new-console-template for more information
using StackExchange.Redis;

Console.WriteLine("--- Pushing/Pulling data from Redis ---");

ConnectionMultiplexer redisCon = ConnectionMultiplexer.Connect("localhost:8082");
IDatabase db = redisCon.GetDatabase();

int x1 = 4;
Double x2 = 6.60654;

db.StringSet("foo", "bar");
db.StringSet("foo2", x1);
db.StringSet("foo3", x2);

string value = db.StringGet("foo");
string value2 = db.StringGet("foo2");
string value3 = db.StringGet("foo3");


Console.WriteLine("output is {0}", value);
Console.WriteLine("output is {0}", value2);
Console.WriteLine("output is {0}", value3);
Console.ReadKey();