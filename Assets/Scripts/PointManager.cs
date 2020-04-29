using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public float poinA, poinB;
    public float poinItemA;
    public TextMeshProUGUI txtPoinA, txtPoinB;
    // Start is called before the first frame update
    void Start()
    {
        poinItemA = 22f;
    }

    // Update is called once per frame
    void Update()
    {
        if(txtPoinA != null)
        {
            poinA += Time.deltaTime * 0.5f;
            txtPoinA.SetText(poinA.ToString("F0"));
        }

        if(txtPoinB != null)
        {
            poinB += Time.deltaTime * 0.5f;
            txtPoinB.SetText(poinB.ToString("F0"));
        }
        
        
    }
}
