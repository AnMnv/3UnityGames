using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForClouds : MonoBehaviour
{
  public float speed;
  public Vector2 dir;
    void FixedUpdate()
    {
      transform.Translate(speed*dir*Time.deltaTime, Space.World);
    }







    void OnTriggerEnter2D(Collider2D other)
      {
            if (other.gameObject.tag=="deadeye")
            {
              //Debug.Log("Test");
            Destroy(gameObject);
            }
      }


}
