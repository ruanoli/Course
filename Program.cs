using Pessoa_Curso.Models;

Person p1 = new Person("Ruan", "Oliveira");
// p1.Age = 27;
// p1.Show();

Person p2 = new Person("Thiago", "Oliveira");

Course c1 = new Course();
c1.Title = "Inglês";
c1.AddStudent(p1);
c1.AddStudent(p2);
c1.ListStudents();
