using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Triggered : MonoBehaviour
{
 public Collider2D coll;

    void Start()
    {
        //Fetch the GameObject's Collider (make sure they have a Collider component)
        coll = GetComponent<PolygonCollider2D>();
        //Here the GameObject's Collider is not a trigger
        coll.isTrigger = false;
    }

    void OnMouseDown()
    {
        
        coll.isTrigger = true;
   
    }
       void OnMouseUp()
    {
        
        coll.isTrigger = false;
   
    }
}
