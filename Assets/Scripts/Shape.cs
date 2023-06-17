using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Shape : MonoBehaviour// ABSTRACTION
{

    public Color shapeColor;    

    private string m_ShapeName;// ENCAPSULATION
    public string shapeName// ENCAPSULATION
    {
        get { return m_ShapeName; }
        set
        {
            if (m_ShapeName == "")
            {
                Debug.LogError("You can't set nothing as a shape!!");
            }
            else
            {
                m_ShapeName = value; // original setter now in if/else statement
            }
        }
    }

    private void Start()
    {
        GetComponent<Renderer>().material.color = shapeColor;
        shapeName = name;
    }

    public abstract void DisplayText();// ABSTRACTION

    public virtual void OnMouseDown()
    {
        DisplayText();
    }
}
