using ConsoleApp8.models;

List<Person> people = new List<Person>()
        {
            new Person(){Id= 1, Name ="zahra",Gender=0,City="shiraz",Address="street 1",Age=12,NationalCode="123456789",mobile=912234567,EmailAddress="zahra@g.com"},
            new Person(){Id= 2, Name ="masi",Gender=0,City="tehran",Address="street 2",Age=20,NationalCode="123456789",mobile=912234567,EmailAddress="masi@g.com"},
            new Person(){Id= 3, Name ="ali",Gender=1,City="esfahan",Address="street 3",Age=35,NationalCode="123456789",mobile=912234567,EmailAddress="ali@g.com"},
            new Person(){Id= 1, Name ="mahsa",Gender=0,City="shiraz",Address="street 1",Age=32,NationalCode="123456789",mobile=912234567,EmailAddress="mahsa@g.com"}



        };
var people30 = people .Where(x => x.Age > 30 && x.Gender==0 ).ToList();
var peopleOrderbyage = people.OrderByDescending(x => x.Age).ToList();
var peopleShiraz = people.Where(x => x.City=="shiraz").Select(i=> i.Name).ToList();
foreach (var item in peopleShiraz)
{
    Console.WriteLine(item);
}
foreach (var item in people30)
{
    Console.WriteLine(item.ToString());
}
foreach (var item in peopleOrderbyage)
{
    Console.WriteLine(item.ToString());

}
Console.ReadKey();