
using System.Collections.Generic;

public enum DrinkingMethod
{
    Method1,
    Method2,
    Method3,
    Custom,
}
public enum Mood
{
    Happy,
    Irritated,
    Rowdy,
    Sad,
    Buzzing,
    Flirty,
    Custom,
}

[System.Serializable]
public abstract class Robot
{
    public string Name;
    public int ModelNumber;
    public RobotTypes Type;
    public CompaniesNames CompaniesNames;

    public string OriginPlanet;

    public DrinkingMethod PrefferedMethod;
    public List<string> FavoriteDrinks;
    public List<string> DislikedDrinks;

    public Mood CurrentMood;
    public float Loyalty;
    public float Constitution;
    public float Intoxication;

    public DailyRoutine Routine;
}
