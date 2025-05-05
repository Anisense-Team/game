using UnityEngine;

public class CombatRobot : Robot
{
    public CombatRobot()
    {
        Name = "Combat";
        MaxHealth = 120;
        ModelNumber = Robot.GetModelNumber(Name);
        Type = RobotTypes.Combat;
        CompanyName = CompaniesNames.Monger;
        Armor = 50;
    }

    void Attack()
    {
        // Attack behavior
    }

    void Reload()
    {
        // Reload behavior
    }

    void Overheat()
    {
        // Overheat behavior
    }
}
