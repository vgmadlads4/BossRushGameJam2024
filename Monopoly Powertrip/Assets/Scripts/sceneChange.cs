using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneChange : MonoBehaviour
{
    public string sceneName;
    public void PlayButton()
    {
        SceneManager.LoadScene(sceneName);
    }
}
