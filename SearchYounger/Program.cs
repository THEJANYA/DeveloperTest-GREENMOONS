using AppData.Modles;

    string userInput;
    int parentID;
    List<PersonModel> parentPerson = new List<PersonModel>();
   
Console.WriteLine("Search person younger ");
Console.WriteLine("Key name : ");
string nameParent = Console.ReadLine();

        parentPerson = PersonModel.personList
                        .Where(x => x.Name.Equals(nameParent))
                        .ToList();
 
var result = from person in PersonModel.personList
             join parent in parentPerson
             on person.ParentID equals parent.ParentID
             where  person.BirthofDate > parent.BirthofDate 
             orderby person.BirthofDate ascending
             select person;

Console.WriteLine("Result : ");

if (result.Count() > 0)
{

    foreach (var i in result)
    {

        Console.WriteLine(i.Name);
    }

}
else {
    Console.WriteLine("Not Found.");
}

 
