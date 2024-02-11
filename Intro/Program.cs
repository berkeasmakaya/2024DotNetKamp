using Intro.Business;
using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables -->camelCase
bool isAuthenticated = true;
Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
	Console.WriteLine("Buton-->Hoşgeldin Engin");
}
else
{
	Console.WriteLine("Buton-->Sisteme giriş yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };//dbden gelecek
																					  //string[] loans2 = new string[6];
																					  //loans2[0] = "Kredi 1";

//start    condition        //increment
for (int i = 0; i < loans.Length; i++)
{
	Console.WriteLine(loans[i]);
}



CourseManager courseManager = new(new EfCourseDal());
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
	Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


Console.WriteLine("kod bitti");

IndividualCustomer customer = new IndividualCustomer();
customer.Id = 1;
customer.NationalIdentity = "123456";
customer.FirstName = "Berke";
customer.LastName = "Asmakaya";
customer.CustomerNumber = "1234";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "1234523436";
customer2.FirstName = "Engin";
customer2.LastName = "Demiroğ";
customer2.CustomerNumber = "345657";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "35434646565";
customer3.TaxNumber = "1234567890";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "53543234646565";
customer4.TaxNumber = "1234567890123";

int number1 = 10;
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1); //output -> 20

//value types --> int, bool, double...

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Adana";
Console.WriteLine(cities2[0]);

//reference types --> array, class, interface

BaseCustomer[] customers = {customer, customer2, customer3, customer4};

//polymorphism
foreach (BaseCustomer customerr in customers)
{
    Console.WriteLine(customerr.CustomerNumber);
}