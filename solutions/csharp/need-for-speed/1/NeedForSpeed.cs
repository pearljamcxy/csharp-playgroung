using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Interfaces;

class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    private int _distance = 0;
    private int _totalBattery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
    }
    public bool BatteryDrained()
    {
        return (_totalBattery < _batteryDrain);
    }

    public int DistanceDriven()
    {
        return _distance;
    }

    public void Drive()
    {
        if (_totalBattery >= _batteryDrain)
        {
            _distance += _speed;
            _totalBattery -= _batteryDrain;
        }
        else
        {
            Console.WriteLine("there is not enough battery!");
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50,4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int _distance;
    
    public RaceTrack(int distance)
    {
        this._distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
        }
        int SofarDistance = car.DistanceDriven();
        return (SofarDistance >= this._distance);
    }
}
