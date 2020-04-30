using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingObject : MonoBehaviour
{
    public float time = 1f;
    public float to = 2f;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.rotateAround(gameObject, Vector3.back, to, time).setEaseInOutSine().setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
