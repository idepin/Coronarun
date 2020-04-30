using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    float currentTime, startTime =4f;
    public TextMeshProUGUI txtCount;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ExtentCountDown.CountDownWithoutTimeScale(3, txtCount, this));

    }
    public static class ExtentCountDown
    {
        public static IEnumerator CountDownWithoutTimeScale(int duration, TextMeshProUGUI txtView, CountDown countDown)
        {
            while (true)
            {
                float pauseEndTime = Time.realtimeSinceStartup + duration;
                while (Time.realtimeSinceStartup < pauseEndTime)
                {
                    //Debug.Log(Time.realtimeSinceStartup + " : " + pauseEndTime);
                    txtView.SetText((pauseEndTime - Time.realtimeSinceStartup).ToString("0"));
                    yield return 0;
                }
                Time.timeScale = 1;
                txtView.transform.parent.gameObject.SetActive(false);
                countDown.enabled = false;
                break;
            }
        }
    }
}
