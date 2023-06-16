using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : Shape
{

    public override void DisplayText()
    {
        print($"HELLO!!\nI'm a {shapeName} and I am {shapeColor.ToString()}");
    }

}
