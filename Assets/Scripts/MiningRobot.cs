using UnityEngine;

public class MiningRobot : Robot
{
    public MiningRobot()
    {
        Name = "Mining";
        MaxHealth = 100;
        ModelNumber = Robot.GetModelNumber(Name);
        Type = RobotEnums.Mining;
        Armor = 20;
    }


    void Mine()
    {
        // Mining behavior
    }

    void Store()
    {
        // Store behavior
    }

    void Overheat()
    {
        //Overheat behavior
    }
}
