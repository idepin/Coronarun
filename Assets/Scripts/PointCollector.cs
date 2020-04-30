using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollector : MonoBehaviour
{
    public PointManager pointManager;
    public AudioClip audioClip;
    public enum Player
    {
        playerA = 1,
        playerB = 2
    }

    public Player player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Item")
        {
            if(player == Player.playerA)
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
    }
}
