﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject playerA, playerB;
    public UserData playerAData, playerBData;
    
    // Start is called before the first frame update
    void Start()
    {
        playerA.GetComponent<Renderer>().material.SetColor("_EmissionColor",playerAData.boxColor);
        playerA.GetComponentInChildren<Light>().color = playerAData.boxColor;
        playerB.GetComponent<Renderer>().material.SetColor("_EmissionColor", playerBData.boxColor);
        playerB.GetComponentInChildren<Light>().color = playerBData.boxColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}