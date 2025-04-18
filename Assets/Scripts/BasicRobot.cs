using UnityEngine;

public class BasicRobot : Robot
{
    public BasicRobot()
    {
        Name = "Basic";
        MaxHealth = 70; 
        ModelNumber = Robot:GetModelNumber(Name);
        Type = RobotEnums.Basic.ToString();
        Armor = 50;
    }


    public void Overheat()
    {

    }
}
