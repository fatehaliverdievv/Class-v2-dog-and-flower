using FlowerBucketTask.Models;

namespace FlowerBucketTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flower flower = new Flower("tulip", "qirmizi ", 1.3f);
            //Flower flower1 = new Flower("papatya", "ag ", 0.3f);
            //Flower flower2 = new Flower("rose", "ag ", 1f);
            //Flower flower3 = new Flower("qerenfil", "qirmizi ", 2f);
            Flower flower1 = new Flower("tulip", "qirmizi ", 1.3f);
            Flower flower2 = new Flower("tulip", "qirmizi ", 1.3f);
            Flower flower3 = new Flower("tulip", "qirmizi ", 1.3f);
            Bucket bucket = new Bucket();
            bucket.AddFlower(flower);
            bucket.AddFlower(flower1);
            bucket.AddFlower(flower2);
            bucket.AddFlower(flower3);
            var result = bucket.TotalPrice(30);
            if(result.hasflower)
            {
                Console.WriteLine(result.Price);
            }
            else
            {
                Console.WriteLine("buketde gul yoxdu");
            }
        }
    }
}