// See https://aka.ms/new-console-template for more information

using System;
using System.Linq; 
using LinqPractices.DbOperations; 
namespace LinqPractices 
{
    class Program { 
        static void Main (string[] args) 
        { 
            DataGenerator.Initialize(); 
            LinqDbContext _context = new LinqDbContext (); 
            var students = _context.Students.ToList<Student>(); 

            Console.WriteLine("*** Find ***") ;
            var student =_context.Students.Where(student => student.StudentId ==1).FirstOrDefault();
            student = _context.Students.Find(2); 
            Console.WriteLine(student.Name); 
        
            //FirstOrDefault
            Console.WriteLine(); 
            Console.WriteLine("*** Find Name ***"); 
            student = _context.Students.Where(student=> student.Surname=="Yılmaz").FirstOrDefault(); 
            Console.WriteLine(student.Name); 

            student= _context.Students.FirstOrDefault(x=> x.Surname=="Yılmaz"); 
            Console.WriteLine(student.Name); 



        }
    }

}