using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
  public Transform spawnZone;
  public GameObject[] obj;




    // Update is called once per frame
  public void Spawnn()
    {
          int k = 0;
        while(k < 8)
        {
          float n = Random.Range(-2.0f, 2.0f);
          Vector2 spawnPos = new Vector2(n, spawnZone.position.y);
          Instantiate(obj[k], spawnPos, Quaternion.identity);
          ++k;
        }
    }
}
