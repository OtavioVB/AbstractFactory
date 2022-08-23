namespace AbstractFactory;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
        var factory = new UserFactory();
        var user = factory.CreateUserModel("Otávio", "Carmanini");
    }

    public interface IAbstractUserFactory
    {
        public IUserModel CreateUserModel(string name, string surname);
    }

    public class UserFactory : IAbstractUserFactory
    {
        public IUserModel CreateUserModel(string name, string surname)
        {
            return new User(name, surname);
        }
    }


    public interface IUserModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    
    public class User : IUserModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;

            // Use Flunt to validate https://github.com/andrebaltieri/Flunt
        }
    }
}