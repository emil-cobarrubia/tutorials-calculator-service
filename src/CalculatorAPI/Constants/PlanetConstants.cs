namespace CalculatorAPI;

public abstract class PlanetConstants
{
    public string Name;
    public double SurfaceGravityMPerS2; // in m/s^2

    public double AvgDistanceFromSun_km; // in km

    public double EquatorialDiameter_km;  // in km

    public double DayLength_hrs;  // in hours

    public double OrbitalPeriod_earthDays;  // in Earth Days

    public int NumberOfMoons;

    public double OrbitalVelocity_km_s; // in km/s

    public const double EscapeVelocity_km_s = 11.2; // in km/s
}
