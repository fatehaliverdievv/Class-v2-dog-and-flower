using AnimalDogTask.Models;
namespace AnimalDogTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog kangal = new Dog("Lucky", "Kangal", "male");
            kangal.Name="Cek";
            //kangal.Birthyear = 2012;
            //kangal.Breed="dada";
            Console.WriteLine($"Name: {kangal.Name}  Breed: {kangal.Breed}  Birthyear: {kangal.Birthyear}");
        }
       
    }
}