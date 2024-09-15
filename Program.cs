using bt;

namespace bt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
        {
            new Student(1, "Phuc ", 17),
            new Student(2, "Binh", 15),
            new Student(3, "Hau ", 18),
            new Student(4, "Dung", 20),
            new Student(5, "Anh", 16)
        };
           
            Console.WriteLine("Danh sach hoc sinh :");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            
            var studentsAge15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            Console.WriteLine("\nDanh sach hoc sinh tuoi 15 den 18 :");
            foreach (var student in studentsAge15to18)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            var studentsWithA = students.Where(s => s.Name.StartsWith("A"));
            Console.WriteLine("\nDanh sach hoc sinh co ten bat dau bang chu  'A':");
            foreach (var student in studentsWithA)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            var totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh : {totalAge}");

            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            if (oldestStudent != null)
            {
                Console.WriteLine($"\nHoc sinh co tuoi lon nhat : ID: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");
            }

            var sortedStudents = students.OrderBy(s => s.Age);
            Console.WriteLine("\nDanh sach  hoc  sinh sau khi sap xep  theo tuoi  tang  dan :");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}