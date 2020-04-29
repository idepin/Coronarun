using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;
    PointManager pointManager;
    public UserData userDataA, userDataB;

    private void Start()
    {
        pointManager = GetComponent<PointManager>();
    }

    public void GameOver()
    {
        StartCoroutine(delayGameOver());
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
