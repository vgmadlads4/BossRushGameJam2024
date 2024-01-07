using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    public void goToScene(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
