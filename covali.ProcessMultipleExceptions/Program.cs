using covali.ProcessMultipleExceptions;

Console.WriteLine("***** Handling Multiple Exceptions *****\n");

Car myCar = new Car("Rusty",90);

try
{
    myCar.Accelerate(-10);
}
catch (CarIsDeadException e)
{
    Console.WriteLine(e.Message);
}

catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);

}


Console.ReadLine();