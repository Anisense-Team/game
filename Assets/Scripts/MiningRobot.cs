using UnityEngine;

public class MiningRobot : Robot
{
    public MiningRobot()
    {
        Name = "Mining";
        MaxHealth = 100;
        ModelNumber = Robot:GetModelNumber(Name);
        Type = RobotEnums.Mining.ToString();
        Armor = 20;
    }


    public void Mine()
    {

    }

    public void Store()
    {

    }

    public void Overheat()
    {

    }
}
