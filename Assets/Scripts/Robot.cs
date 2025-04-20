using UnityEngine;
using System;
using System.Security.Cryptography;
using System.Text;

public abstract class Robot
{
    public string Name { get; protected set; } = string.Empty;
    public int MaxHealth { get; protected set; } = 0;
    public int ModelNumber { get; protected set; } = 0;
    public RobotEnums Type { get; protected set; } = RobotEnums.None;
    public CompanyEnums CompanyName { get; protected set; } = CompanyEnums.None;
    public int Armor { get; protected set; } = 0;
    public Vector3 initialPosition;

    public static int GetModelNumber(string text)
    {
        byte[] bytes = Encoding.Unicode.GetBytes(text);
        SHA256Managed hashstring = new SHA256Managed();
        byte[] hash = hashstring.ComputeHash(bytes);
        string hashString = string.Empty;
        foreach (byte x in hash)
        {
            hashString += String.Format("{0:x2}", x);
        }
        string first8 = hashString.Substring(0, 8);
        int modelNumber = Convert.ToInt32(first8, 16);
        return modelNumber;
    }
}
