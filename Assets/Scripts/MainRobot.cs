using UnityEngine;

public class MainRobot : Robot
{
    public MainRobot()
    {
        Name = "Mining";
        MaxHealth = 100;
        ModelNumber = Robot:GetModelNumber(Name);
        Type = RobotEnums.Main.ToString();
        Armor = 20;
    }

    public void Overheat()
    {

    }
}
