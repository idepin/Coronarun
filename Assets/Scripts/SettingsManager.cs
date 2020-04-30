using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsManager : MonoBehaviour
{
    public TMP_Dropdown dropdownQuality;
    public Slider sliderVolume;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }

    public void SetQuality(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
