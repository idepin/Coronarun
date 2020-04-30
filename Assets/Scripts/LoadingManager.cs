using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingManager : MonoBehaviour
{

    public GameObject loadingScreen;
    public Slider slider;
    public GameObject exitPanel;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    public void ExitApp()
    {
        Application.Quit();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            exitPanel.SetActive(true);
        }
    }
    public void LoadScene(int index)
    {
        StartCoroutine(LoadAsynchronously(index));
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            slider.value = progress;
            yield return null;
        }
    }
}
