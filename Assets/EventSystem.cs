using System;

public static class EventSystem
{
    public static event Action<int> Plant;
    public static event Action<string> Plantname;

    public static void TriggerPlant(int sun)
    {
        Plant?.Invoke(sun);
    }

    public static void CheakPlant(string name)
    {
        Plantname?.Invoke(name);
    }
}