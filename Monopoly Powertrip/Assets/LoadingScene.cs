using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class LoadingScene : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Image LoadingBarFill;
    

    public void LoadScene(int sceneNum)
    {
        StartCoroutine(LoadSceneAsync(sceneNum));
        
    }

    IEnumerator LoadSceneAsync(int sceneNum)//Loading time depends on how long it takes to load files in next scene. Soooo it's a bit too fast rn T-T
    {
        AsyncOperation OP = SceneManager.LoadSceneAsync(sceneNum);

        LoadingScreen.SetActive(true);

        while (!OP.isDone)
        {
            float progress_Value = Mathf.Clamp01(OP.progress / 0.3f);

            LoadingBarFill.fillAmount = progress_Value;

            yield return null;

        }
    }

    
}
