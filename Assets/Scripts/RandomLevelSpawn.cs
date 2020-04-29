using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLevelSpawn : MonoBehaviour
{
    public GameObject[] floor;
    float time;
    public float delay, destroyDelay;
    // Start is called before the first frame update
    Vector3 nextPos;
    void Start()
    {
        time = delay;
        Add();
    }
    void Add()
    {
        GameObject o = Instantiate(floor[Random.Range(0, floor.Length)], nextPos, Quaternion.identity);
        o.SetActive(true);
        Destroy(o, destroyDelay);
        nextPos.z += 270f;
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Add();
    }
}
