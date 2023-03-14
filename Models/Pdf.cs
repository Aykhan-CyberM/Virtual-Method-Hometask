
namespace ConsoleApp13.Models
{
    public class Pdf
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual void  Eat()
        {
            Console.WriteLine("It's Pdf");
        }

    }
}
