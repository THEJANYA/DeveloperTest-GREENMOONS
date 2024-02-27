using AppData;
using AppData.Modles;

string userInput;
int parentID;
List<PersonModel> keyPerson = new List<PersonModel>();

Console.WriteLine("Search person older ");
Console.WriteLine("Key name : ");
string nameParent = Console.ReadLine();

keyPerson = PersonModel.personList
                .Where(x => x.Name.Equals(nameParent))
                .ToList();

var result = from listPerson in PersonModel.personList
             join Person in keyPerson
             on listPerson.ParentID equals Person.ParentID
             where Person.BirthofDate  > listPerson.BirthofDate 
             orderby listPerson.BirthofDate descending
             select listPerson;

Console.WriteLine("Result : ");

if (result.Count() > 0)
{

    foreach (var i in result)
    {

        Console.WriteLine(i.Name);
    }

}
else
{
    Console.WriteLine("Not Found.");
}