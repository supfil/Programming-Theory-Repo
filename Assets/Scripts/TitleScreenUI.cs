using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenUI : MonoBehaviour
{

    public void NextScene()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
}
