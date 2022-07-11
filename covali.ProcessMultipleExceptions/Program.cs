using covali.ProcessMultipleExceptions;
using System.IO;


Console.WriteLine("***** Handling Multiple Exceptions *****\n");

Car myCar = new Car("Rusty",90);

try
{
    myCar.Accelerate(89);
}
catch (CarIsDeadException e)
{
    //FileStream fileStream = File.Open(@"C:\carErrors.txt", FileMode.Open);
    Console.WriteLine(e.Message);
}

catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    myCar.CrankTunes(false);
}
Console.ReadLine();