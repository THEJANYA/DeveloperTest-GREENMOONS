namespace AppData.Modles
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public DateTime BirthofDate { get; set; }

        public int? ParentID { get; set; }



        public static readonly List<PersonModel> personList = new List<PersonModel>
        {
              new PersonModel { Id = 1,Name = "Lee",Role ="Grand Father", BirthofDate = DateTime.Parse("7May1890"),ParentID = 1 },
              new PersonModel { Id = 2,Name = "Robert",Role ="Son", BirthofDate = DateTime.Parse("10July1920"),ParentID = 1 },
              new PersonModel { Id = 3,Name = "Kris",Role ="daughter", BirthofDate = DateTime.Parse("26December1944"),ParentID = 1 }
        };
    }
}
