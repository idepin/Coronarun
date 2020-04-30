using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;
    PointManager pointManager;
    public UserData userDataA, userDataB;
    public TextMeshProUGUI txtPlayerWin, txtScore;

    private void Start()
    {
        pointManager = GetComponent<PointManager>();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        StartCoroutine(delayGameOver());
        if(pointManager.poinA > pointManager.poinB)
        {
            txtPlayerWin.SetText(userDataA.username + " Win!");
            txtScore.SetText(pointManager.poinA.ToString("F0"));
        }
        else if(pointManager.poinB > pointManager.poinA)
        {
            txtPlayerWin.SetText(userDataB.username + " Win!");
            txtScore.SetText(pointManager.poinB.ToString("F0"));
        }
    }

    IEnumerator delayGameOver()
    {
        yield return new WaitForSeconds(0.7f);
        gameOverUI.SetActive(true);
        if(userDataA.highestScore < pointManager.poinA)
        {
            userDataA.highestScore = pointManager.poinA;
        }
        if (userDataB.highestScore < pointManager.poinB)
        {
            userDataB.highestScore = pointManager.poinB;
        }
        Time.timeScale = 0f;

    }
}
