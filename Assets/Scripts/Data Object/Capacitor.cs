﻿public class Capacitor: Device
{
    public override TypeEnum DeviceType
    {
        get { return TypeEnum.Capacitor; }
    }

    public string Node1 = null;
    public string Node2 = null;
    public double Resistance = 100;

    public override string ToString()
    { 
        return "C" + DeviceName + " " + Node1 + " " + Node2 + " " + Device.ConvertValueToString(Resistance);
    }

    public void SetNode1(string node1)
    {
        Node1 = node1;
    }

    public void SetNode2(string node2)
    {
        Node2 = node2;
    }
}
