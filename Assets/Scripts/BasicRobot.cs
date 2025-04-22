using UnityEngine;

public class BasicRobot : Robot
{
    public BasicRobot()
    {
        Name = "Basic";
        MaxHealth = 70; 
        ModelNumber = Robot.GetModelNumber(Name);
        Type = RobotTypes.Basic;
        CompanyName = Companies.Anisense;
        Armor = 50;
    }


    void Overheat()
    {

    }
}
