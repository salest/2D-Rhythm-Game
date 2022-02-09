using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
    public static LoadManager instance;

    public GameObject loadingScreen;
    public Slider slider;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {          
            instance = this;
        }
    }

    public void LoadLevel(int sceneIndex)
    {
        SoundEffectManager.instance.PlaySoundEffect(0);
        StartCoroutine(LoadAsynchronously(sceneIndex)); 
    }

    public void RetryLevel()
    {
        SoundEffectManager.instance.PlaySoundEffect(0);
        Scene currentScene = SceneManager.GetActiveScene();
        StartCoroutine(LoadAsynchronously(currentScene.buildIndex));
    }

    public void LoadLevelFadeMusic(int sceneIndex)
    {
        SoundEffectManager.instance.PlaySoundEffect(0);
        StartCoroutine(LoadAsynchronouslyFadeMusic(sceneIndex));
    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);
        slider.value = 0;
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            yield return null;
        }
        
    }

    IEnumerator LoadAsynchronouslyFadeMusic(int sceneIndex)
    {
        loadingScreen.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);      
        slider.value = 0;
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            yield return null;
        }

    }

}
