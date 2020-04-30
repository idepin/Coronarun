using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollector : MonoBehaviour
{
    public PointManager pointManager;
    public AudioClip audioClip, audioClip2;
    public enum Player
    {
        playerA = 1,
        playerB = 2
    }

    public Player player;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ItemA")
        {
            if (player == Player.playerA)
            {
                pointManager.poinA += pointManager.poinItemA;
            }
            else
            {
                pointManager.poinB += pointManager.poinItemA;
            }
            pointManager.GetComponent<AudioSource>().PlayOneShot(audioClip);
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "ItemB")
        {
            if (player == Player.playerA)
            {
                pointManager.poinA += pointManager.poinItemB;
            }
            else
            {
                pointManager.poinB += pointManager.poinItemB;
            }
            pointManager.GetComponent<AudioSource>().PlayOneShot(audioClip2);
            Destroy(other.gameObject);
        }
    }
}
