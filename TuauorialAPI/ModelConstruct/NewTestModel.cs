using TuauorialAPI.Models;

namespace TuauorialAPI.ModelConstruct
{
    public class NewTestModel
    {

        public NewTestModel(int id, string name, int age, DateTime created, string sex)
        {
            
            Id = id;
            Name = name;
            Age = age;
            Created = created;
            Sex = sex;
        }

        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }
        public string Sex { get; set; }
    }
}
