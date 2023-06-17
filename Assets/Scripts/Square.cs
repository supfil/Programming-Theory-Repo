using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape   // INHERITANCE
{
    public override void DisplayText()// POLYMORPHISM
    {
        print($"HELLO!!\nMy color is {shapeColor.ToString()} and I am a {shapeName}");
    }
}
