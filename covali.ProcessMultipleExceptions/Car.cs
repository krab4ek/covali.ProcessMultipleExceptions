namespace covali.ProcessMultipleExceptions;

internal class Car
{
    public const int MaxSpeed = 100;

    public int CurrentSpeed { get; set; } = 0;
    public string PetName { get; set; } = string.Empty;

    // private bool carIsDead;

    private Radio theMusicBox = new Radio();

    public Car()
    {

    }
    public Car(string name, int speed)
    {
        CurrentSpeed = speed;
        PetName = name;
    }

    public void CrankTunes(bool state)
    {
        theMusicBox.TurnOn(state);
    }

    public void Accelerate(int delta)
    {
        if (delta < 0)
        {
            throw new
                ArgumentOutOfRangeException("delta","Speed must be  greater than zero!");
        }
        CarIsDeadException ex = new CarIsDeadException($"{PetName} has overheating",
            "You have a lead foot",DateTime.Now);

        ex.HelpLink = "http://www.test.com";
        throw ex;
        
           
    }
}
