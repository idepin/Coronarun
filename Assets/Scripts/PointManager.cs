using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public float poinA, poinB;
    public float poinItemA, poinItemB;
    public TextMeshProUGUI txtPoinA, txtPoinB;
    public GameObject playerA, playerB;
    // Start is called before the first frame update
    void Start()
    {
        //poinItemA = 22f;
    }

    // Update is called once per frame
    void Update()
    {
        txtPoinA.SetText(poinA.ToString("F0"));
        txtPoinB.SetText(poinB.ToString("F0"));

        if (txtPoinA != null && playerA.activeInHierarchy)
        {
            poinA += Time.deltaTime * 0.5f;

        }

        if (txtPoinB != null && playerB.activeInHierarchy)
        {
            poinB += Time.deltaTime * 0.5f;

        }
        
    }
}
