using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    public override void DisplayText()
    {
        print($"HELLO!!\nMy color is {shapeColor.ToString()} and I am a {shapeName}");
    }
}
