using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    public Transform SpawnPos1;
    public Transform SpawnPos2;
    public Transform SpawnPos3;
    public Transform SpawnPos4;
    public GameObject cloud1;
    public GameObject cloud2;
    public GameObject cloud3;
    public GameObject cloud4;
    public float TimeSpawn;


    void Start()
    {
      StartCoroutine(SpawnA());
    }
    void Repeat()
    {
      StartCoroutine(SpawnA());
    }

    IEnumerator SpawnA()
    {
      yield return new WaitForSeconds(TimeSpawn);
      Instantiate(cloud1, SpawnPos1.position, Quaternion.identity);
      Instantiate(cloud2, SpawnPos2.position, Quaternion.identity);
      Instantiate(cloud3, SpawnPos3.position, Quaternion.identity);
      Instantiate(cloud4, SpawnPos4.position, Quaternion.identity);
      Repeat();
    }
}
