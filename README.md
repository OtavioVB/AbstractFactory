# Abstract Factory

**Abstract Factory** é um **[padrão criacional](https://refactoring.guru/pt-br/design-patterns/creational-patterns#:~:text=Os%20padr%C3%B5es%20criacionais%20fornecem%20v%C3%A1rios,reutiliza%C3%A7%C3%A3o%20de%20c%C3%B3digo%20j%C3%A1%20existente.&text=Fornece%20uma%20interface%20para%20criar,de%20objetos%20que%20ser%C3%A3o%20criados.)** de **[design pattern](https://pt.wikipedia.org/wiki/Padr%C3%A3o_de_projeto_de_software)** criado pelo **[GoF](https://pt.wikipedia.org/wiki/Gangue_dos_quatro)**. Tal meio de padrão de projeto é utilizado como forma de **[abstrair](https://pt.stackoverflow.com/questions/23103/o-que-%C3%A9-abstra%C3%A7%C3%A3o) a instância de [objetos](https://pt.wikipedia.org/wiki/Objeto_(ci%C3%AAncia_da_computa%C3%A7%C3%A3o))**, de modo que o desenvolvedor não saiba como tal elemento do sistema (o objeto) é instanciado. Assim sendo, esse tipo de padrão (criacional) cria uma flexibilidade de **quem cria** e **como é criado**.

## O que difere o Abstract Factory dos outros padrões criacionais?

Abstract Factory **fornece uma [interface](https://pt.wikipedia.org/wiki/Interface_(ci%C3%AAncia_da_computa%C3%A7%C3%A3o)) para criação de família de objetos sem especificar suas classes concretas**. Ou seja, o desenvolvedor que utiliza esse padrão, fica em alto nível (longe de conhecer as "entranhas de instanciação do objeto"), não acaba conhecendo qual classe de fato é implementada, apenas acaba conhecendo sua abstração.

Veja a seguir um exemplo de código utilizando esse padrão:

```cs
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
```