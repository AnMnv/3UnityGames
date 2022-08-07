 ﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    Rigidbody2D rb;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision){
      if(collision.gameObject.name.Equals("mainhero")){
          Invoke("FallingPlatform", 1f);
          Destroy(gameObject, 2f);
      }
    }

 void FallPlatform(){
      rb.isKinematic = false;
    }
}
