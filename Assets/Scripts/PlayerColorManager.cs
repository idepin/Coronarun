using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorManager : MonoBehaviour
{
    public GameObject playerA, playerB;
    public Color colorA, colorB, colorC;
    public UserData playerAData, playerBData;

    public void ApplyColor()
    {
        playerAData.boxColor = playerA.GetComponent<Renderer>().material.GetColor("_EmissionColor");
        playerBData.boxColor = playerB.GetComponent<Renderer>().material.GetColor("_EmissionColor");
    }
    public void ChangeColor(int index)
    {
        switch (index)
        {
            case 0:
                playerA.GetComponent<Renderer>().material.SetColor("_EmissionColor", colorA);
                playerA.GetComponentInChildren<Light>().color = colorA;
                break;
            case 1:
                playerA.GetComponent<Renderer>().material.SetColor("_EmissionColor", colorB);
                playerA.GetComponentInChildren<Light>().color = colorB;
                break;
            case 2:
                playerA.GetComponent<Renderer>().material.SetColor("_EmissionColor", colorC);
                playerA.GetComponentInChildren<Light>().color = colorC;
                break;
        }
        
    }
    public void ChangeColorB(int index)
    {
        switch (index)
        {
            case 0:
                playerB.GetComponent<Renderer>().material.SetColor("_EmissionColor", colorA);
                playerB.GetComponentInChildren<Light>().color = colorA;
                break;
            case 1:
                playerB.GetComponent<Renderer>().material.SetColor("_EmissionColor", colorB);
                playerB.GetComponentInChildren<Light>().color = colorB;
                break;
            case 2:
                playerB.GetComponent<Renderer>().material.SetColor("_EmissionColor", colorC);
                playerB.GetComponentInChildren<Light>().color = colorC;
                break;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        playerA.GetComponent<Renderer>().material.SetColor("_EmissionColor", playerAData.boxColor);
        playerA.GetComponentInChildren<Light>().color = playerAData.boxColor;
        playerB.GetComponent<Renderer>().material.SetColor("_EmissionColor", playerBData.boxColor);
        playerB.GetComponentInChildren<Light>().color = playerBData.boxColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
