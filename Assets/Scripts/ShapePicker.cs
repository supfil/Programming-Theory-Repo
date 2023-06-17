using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShapePicker : MonoBehaviour
{
    private GameObject chosenShape;
    private GameObject[] pickAShape = GameManager.Instance.shapeAviable;
    public Button buttonPrefab;

    public List<Button> buttonList = new List<Button>();

    private void Start()
    {
        foreach (GameObject gameobject in pickAShape)
        {
            var newButton = Instantiate(buttonPrefab, transform);
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = gameobject.name;


            newButton.onClick.AddListener(() =>
            {
                chosenShape = gameobject;
                foreach (Button button in buttonList)
                {
                    button.interactable = true;
                }

                newButton.GetComponent<Button>().interactable = false;
            });
            newButton.GetComponent<Button>().interactable = true;

            buttonList.Add(newButton);
        }
    }
}
