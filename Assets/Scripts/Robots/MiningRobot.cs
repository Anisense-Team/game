using UnityEngine;

public class MiningRobot : Robot
{
    public MiningRobot()
    {
        Name = "Mining";
        MaxHealth = 100;
        ModelNumber = Robot.GetModelNumber(Name);
        Type = RobotTypes.Mining;
        CompanyName = CompaniesNames.Parlax;
        Armor = 20;
    }

    void Harvest()
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
