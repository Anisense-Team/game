using UnityEngine;

public class CombatRobot : Robot
{
    public CombatRobot()
    {
        Name = "Combat";
        MaxHealth = 120;
        ModelNumber = Robot:GetModelNumber(Name);
        Type = RobotEnums.Combat.ToString();
        Armor = 50;
    }


    public void Attack()
    {

    }

    public void Reload()
    {

    }

    public void Overheat()
    {

    }
}
