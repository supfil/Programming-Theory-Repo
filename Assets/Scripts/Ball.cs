using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : Shape    // INHERITANCE
{

    public override void DisplayText()// POLYMORPHISM
    {
        print($"HELLO!!\nI'm a {shapeName} and I am {shapeColor.ToString()}");
    }

}
