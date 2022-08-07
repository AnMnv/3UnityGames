using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forshield : MonoBehaviour
{

void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.tag=="hero")
    {
      Destroy(gameObject);


    }
  }

}
