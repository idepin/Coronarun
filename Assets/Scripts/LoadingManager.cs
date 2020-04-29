using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadSceneAsync(index);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
