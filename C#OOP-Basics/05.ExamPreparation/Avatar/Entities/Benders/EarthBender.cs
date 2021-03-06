﻿public class EarthBender : Bender
{
    private double groundSaturation;
    private double totalPower;

    public EarthBender(string name, int power, double groundSaturation)
        : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public double GroundSaturation
    {
        get { return this.groundSaturation; }
        set { this.groundSaturation = value; }
    }

    public override double GetPower() => this.Power * this.GroundSaturation;

    public override string ToString()
    {
        return $"{base.ToString()}, Ground Saturation: {this.GroundSaturation:F2}";
    }
}
