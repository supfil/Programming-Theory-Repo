using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShapePicker : MonoBehaviour
{
    public ButtonUI createButton;

    
    private GameObject[] pickAShape = GameManager.Instance.shapeAviable;
    public Button buttonPrefab;

    private List<Button> buttonList = new List<Button>();

    private void Start()
    {
        createButton = GameObject.Find("CreateButton").GetComponent<ButtonUI>();

        foreach (GameObject gameobject in pickAShape)
        {
            var newButton = Instantiate(buttonPrefab, transform);
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = gameobject.name;


            newButton.onClick.AddListener(() =>
            {
                createButton.gameObject = gameobject;
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
