namespace Genomgång
{
    class Person
    {
        string _name;

        int _age;
        
        Animal _pet;

        public Person(string name, int age, Animal pet)
        {
            _name = name;
            _age = age;
            _pet = pet;

        }

        public void ActivatePet()
        {
            _pet.Poop();
        }
        public void Eat()
        {
            System.Console.WriteLine(_name + " is eating!");
        }
        public void Sleep()
        {
            System.Console.WriteLine(_name + " is sleeping!");
        }
    }
}