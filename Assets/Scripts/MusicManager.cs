using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] audioClips;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(PlayMusic());
    }

    int GetRandomIndex()
    {
        return Random.Range(0, audioClips.Length);
    }

    IEnumerator PlayMusic()
    {
        while (true)
        {
            int index = GetRandomIndex();
            audioSource.clip = audioClips[index];
            audioSource.Play();
            yield return new WaitForSeconds(audioClips[index].length);
        }
        

    }
}
