// See https://aka.ms/new-console-template for more information
using intro.Business;
using intro.DataAccess.Concretes;
using intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables --> camelCase
bool isAuthenticated = true;

Console.WriteLine(message1);

//condition
if (isAuthenticated == true )
{
    Console.WriteLine("Hoşgeldin");
}
else
{
    Console.WriteLine("Giriş yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3 ", "Kredi 4", "Kredi 5", "Kredi 6" };

string[] loans2 = new string[6];
loans2[0] = "Kredi 1";

//   start     condition         increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

//CourseManager courseManager = new(new CourseDal());
//CourseManager courseManager = new(new EfCourseDal());
CourseManager courseManager = new(new DapperCourseDal());

List<Course> courses = courseManager.GetAll();

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

Console.WriteLine("kod bitti şimdilik...");

IndividualCustomer customer1= new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirsName = "Ferhat";
customer1.LastName = "TURUÇ";
customer1.CustomerNumber = "123451";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345678910";
customer2.FirsName = "Ogün";
customer2.LastName = "ESİN";
customer2.CustomerNumber = "123452";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "123453";
customer3.TaxNumber = "12345678910";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer3.Name = "JSGA";
customer4.CustomerNumber = "123454";
customer4.TaxNumber = "12345678911";

//value types --> int, bool, double...
int number1 = 10;
int number2 = 20;

number1 = number2;
number2 = 50;
Console.WriteLine(number1);

// reference types --> array, class, interface...
string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Adana";
Console.WriteLine(cities2[0]);

//polymorphism
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach( BaseCustomer customer in customers )
{
    Console.WriteLine(customer.CustomerNumber);
}

