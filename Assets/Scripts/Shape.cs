using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Shape : MonoBehaviour
{

    public Color shapeColor;

    private string m_ShapeName;
    public string shapeName
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

    public abstract void DisplayText();

    public virtual void OnMouseDown()
    {
        DisplayText();
    }
}
