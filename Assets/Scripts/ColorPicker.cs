using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    private Color chosenColor;
    private Color[] pickAColor = GameManager.Instance.colorAviable;
    public Button buttonPrefab;

    public List<Button> buttonList = new List<Button>();

    private void Start()
    {
        foreach(Color colors in pickAColor)
        {
            var newButton = Instantiate(buttonPrefab, transform);
            newButton.GetComponent<Image>().color = colors;

            
            newButton.onClick.AddListener(() =>
            {
                chosenColor = colors;
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
