using UnityEngine;

public class MainRobot : Robot
{
    public MainRobot()
    {
        Name = "Mining";
        MaxHealth = 100;
        ModelNumber = Robot.GetModelNumber(Name);
        Type = RobotEnums.Main;
        CompanyName = CompanyEnums.Anisense;
        Armor = 20;
    }

    void Overheat()
    {
        // Overheat behavior here
    }
}
