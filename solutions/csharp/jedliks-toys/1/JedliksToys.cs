using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class RemoteControlCar
{
    public int Battery {get; private set;} = 100;
    public int Distance {get; private set;} = 0;

    public static RemoteControlCar Buy()
    {
        
        var car = new RemoteControlCar();
        return car;
        
    }

    public string DistanceDisplay()
    {
        return $"Driven {Distance} meters";
    }

    public string BatteryDisplay()
    {
        if (Battery >= 1) {
            return $"Battery at {Battery}%";
        }
        return "Battery empty";
    }
    
    public void Drive()
    {
        if (Battery >= 1)
        {
            Distance += 20;
            Battery -= 1;
        }
        else
        {
            return;
        }
    }
}
