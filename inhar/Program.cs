using inhar;

empmethod empmethod = new empmethod();

employe v1 = new employe();


Console.WriteLine("enter first name");
v1.FirstName = Console.ReadLine();
Console.WriteLine("enter last name");
v1.LastName = Console.ReadLine();


bool p = empmethod.addemployee(v1);