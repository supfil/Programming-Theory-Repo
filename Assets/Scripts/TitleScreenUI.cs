using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NextScene()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
}
