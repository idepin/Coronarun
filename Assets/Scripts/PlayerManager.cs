using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject playerAMat;
    public UserData playerAData;
    // Start is called before the first frame update
    void Start()
    {
        playerAMat.GetComponent<Renderer>().material.SetColor("_EmissionColor",playerAData.boxColor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
