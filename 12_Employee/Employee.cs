namespace _12_Employee
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public string Type;

        public Employee()
        {

        }
        public Employee(string name, string ocupation, int id)
        {
            Name = name;
            Type = ocupation;
            Id = id;
        }

      
    }
}