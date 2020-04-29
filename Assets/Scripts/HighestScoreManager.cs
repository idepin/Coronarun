using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighestScoreManager : MonoBehaviour
{
    public TextMeshProUGUI usernameA, usernameB, scoreA, scoreB;
    public UserData userDataA, userDataB;
    public GameObject userB;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable()
    {
        if(userDataB.highestScore > userDataA.highestScore)
        {
            userB.transform.SetAsFirstSibling();
        }
        usernameA.SetText(userDataA.username);
        usernameB.SetText(userDataB.username);
        scoreA.SetText(userDataA.highestScore.ToString("F0"));
        scoreB.SetText(userDataB.highestScore.ToString("F0"));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
