using ConsoleApp13.Models;

Pdf pdf = new Pdf();
Excel excel= new Excel();
object[] arr = { pdf, excel };
foreach (var item in arr)
{
    Console.WriteLine(item);

}