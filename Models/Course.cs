namespace Pessoa_Curso.Models
{
    public class Course
    {
        public string Title { get; set; }
        public List<Person> Students { get; set; } = new();

        public void AddStudent(Person student)
        {
            Students.Add(student);
        }

        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student);
        }

        public int GetStudentsEnrolled()
        {
            return Students.Count();
        }

        public void ListStudents()
        {
            Console.WriteLine($"Alunos do curso de {Title}:");
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {Students[i].FullName}");
            }
            // foreach(var aluno in Students)
            // {
            //     Console.WriteLine(aluno.FullName);
            // }
        }
    }
}