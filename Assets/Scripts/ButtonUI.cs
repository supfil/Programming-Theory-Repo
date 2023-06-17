using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    public Color color;
    public GameObject gameObject;


    GameObject removeGameObject;

    public void CreateShape()
    {
        if (removeGameObject != null)
            Destroy(removeGameObject);
        removeGameObject = Instantiate(gameObject, new Vector3(0f, 0f, 0f), Quaternion.identity);

        if (removeGameObject.GetComponent<Ball>() != null)
            removeGameObject.GetComponent<Ball>().shapeColor = color;
        else if (removeGameObject.GetComponent<Square>() != null)
            removeGameObject.GetComponent<Square>().shapeColor = color;
    }
}
