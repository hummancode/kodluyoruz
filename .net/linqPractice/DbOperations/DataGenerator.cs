
using System.Linq; 
namespace LinqPractices.DbOperations {
    public class DataGenerator  {
        public static void Initialize() 
        {
            using(var context = new LinqDbContext())
            {
                if(context.Students.Any()) {
                    return; 
                }
                context.Students.AddRange
                (
                    new Student() {
                        
                        Name = "Ayşe", 
                        Surname = "Yılmaz", 
                        ClassId = 1 
                    },
                    new Student() {
                       
                        Name = "Asn", 
                        Surname = "Yılmaz", 
                        ClassId = 5 
                    },
                    new Student() {
                      
                        Name = "Fatma", 
                        Surname = "Ayar", 
                        ClassId = 5 
                    }

                );
                context.SaveChanges(); 
            }
        }
    }
}