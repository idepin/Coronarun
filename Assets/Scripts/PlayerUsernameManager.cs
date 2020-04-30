using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUsernameManager : MonoBehaviour
{
    public TMP_InputField txtUsernameA, txtUsernameB;
    public UserData userDataA, userDataB;

    public void SetUsernameA(string username)
    {
        userDataA.username = username;
    }
    public void SetUsernameB(string username)
    {
        userDataB.username = username;
    }

    public void UpdateUI()
    {
        txtUsernameA.text = userDataA.username;
        txtUsernameB.text = userDataB.username;
    }
}
