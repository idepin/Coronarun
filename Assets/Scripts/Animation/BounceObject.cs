using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(gameObject, 71f, 1f).setEaseInBounce().setLoopPingPong();
        //LeanTween.rotateAround(gameObject)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
