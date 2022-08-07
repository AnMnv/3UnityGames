using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
  private float speedV;
     void Start () { speedV = Random.Range(0.3f, 0.3f);


      }
       void Update ()
      {
         transform.Translate(0, speedV * Time.deltaTime, 0);
         if (transform.position.y > 0.2)
          {
           speedV = -speedV;
          }

        if (transform.position.y < -0.2)
          {
          speedV = Random.Range(0.3f, 0.3f);
          }

     }


}
