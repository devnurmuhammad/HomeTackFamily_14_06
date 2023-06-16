namespace HomeTackFamily_14_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.Ism = "Sanjarbek";


            Person.FHDYO(person1, person2);
            Console.WriteLine(person1.Ism + " " + person1.oilalimi);

        }
        
    }
}