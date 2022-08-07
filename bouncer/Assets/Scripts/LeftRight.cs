using UnityEngine;
using System.Collections;
public class LeftRight : MonoBehaviour
{
  private float speedV;
   void Start () { speedV = Random.Range(0.5f, 3);


    }
     void Update ()
    {
       transform.Translate(speedV * Time.deltaTime, 0, 0);
       if (transform.position.x > 1)
        {
         speedV = -speedV;
        }

      if (transform.position.x < -1)
        {
        speedV = Random.Range(0.5f, 3);
        }

   }
 }
