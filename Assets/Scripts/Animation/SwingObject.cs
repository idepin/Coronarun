using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingObject : MonoBehaviour
{
    public float time = 1f;
    public float add = 35f;
    public Vector3 angle;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.rotateAround(gameObject, angle, add, time).setEaseInOutSine().setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
