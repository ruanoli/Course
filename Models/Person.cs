namespace Pessoa_Curso.Models
{
    public class Person
    {
        public Person()
        {
            
        }
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        private string _name;
        private string _lastName;
        private int _age;
        public string Name 
        {
            get => _name.ToUpper();
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentException("Nome não informado.");

                _name = value;
            }
        }
        public string LastName 
        {
            get => _lastName.ToUpper();
            set => _lastName = value;
        }
        public string FullName => $"{Name} {LastName}";
        public int Age 
        {
            get => _age;
            set
            {
                if( value < 0)
                    throw new ArgumentException("Idade inexistente.");

                _age = value;
            } 
        }

        public void Show()
        {
            Console.WriteLine($"Olá, eu sou {FullName} e tenho {Age} anos");
        }
    }
}