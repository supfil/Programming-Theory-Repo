using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Color[] colorAviable;
    public GameObject[] shapeAviable;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void CreateShape(GameObject gameObject, Color color)
    {
        var shape = Instantiate(gameObject, transform);

        if (shape.GetComponent<Ball>() != null)
            shape.GetComponent<Ball>().shapeColor = color;
        else
            shape.GetComponent<Square>().shapeColor = color;
    }
}
