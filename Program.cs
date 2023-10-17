
using System.Net.Sockets;

namespace LinqToObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() {

               new Student() {Id=101, Name="Joshit", Address="Kollam"},
               new Student() {Id=102, Name="Neel", Address="Nasik"},
               new Student() {Id=103, Name="albin", Address="Kannur"}
               };
            students.Select(student => new
            {
                FullName = student.Name,
                Location = student.Address,
                Country = "India"
            }).OrderBy(student => student.FullName).ToList()
            .ForEach(student => Console.WriteLine(student.FullName + " " + student.Location + " " + student.Country));

        }
    }
}