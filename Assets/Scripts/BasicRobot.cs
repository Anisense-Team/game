using UnityEngine;

public class BasicRobot : Robot
{
    public BasicRobot()
    {
        Name = "Basic";
        MaxHealth = 70; 
        ModelNumber = Robot.GetModelNumber(Name);
        Type = RobotEnums.Basic;
        CompanyType = CompanyEnums.Anisense;
        Armor = 50;
    }


    void Overheat()
    {

    }
}
