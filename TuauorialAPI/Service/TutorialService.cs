using System.Reflection;
using TuauorialAPI.Data;
using TuauorialAPI.Interfaces;
using TuauorialAPI.ModelConstruct;
using TuauorialAPI.Models;

namespace TuauorialAPI.Service
{
    public class TutorialService : ITutorialInterface
    {

        private readonly DataContext _context;

        public TutorialService(DataContext context)
        {
            _context = context;
        }

        public List<TestModel> GetTestModels()
        {
            var model = new List<TestModel>();

            model = _context.TestModel.ToList();
            return model;

        }
    }
    //{
    //    public List<TestModel> GetTestModels()
    //    {
    //        var model = new List<TestModel>();
    //        try {
    //            model.Add(new TestModel(0, "Ayaz", 24, DateTime.Now, "M"));
    //            model.Add(new TestModel(1, "Artur", 22, DateTime.Now, "Y"));
    //            model.Add(new TestModel(2, "Arzhan", 19, DateTime.Now, "Y"));
    //            model.Add(new TestModel(3, "Danila", 19, DateTime.Now, "Y"));
    //            model.Add(new TestModel(4, "Dania", 20, DateTime.Now, "G"));

    //            return model;
    //        }
    //        catch(Exception ex ) {
    //            Console.WriteLine( ex.ToString() );
    //            return new List<TestModel>();
    //        }

    //    }
}
