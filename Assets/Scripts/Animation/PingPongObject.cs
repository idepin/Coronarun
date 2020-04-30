﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongObject : MonoBehaviour
{
    public float maxY = 1f;
    public float time = 1f;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(gameObject, maxY, time).setEaseInExpo().setLoopPingPong();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
