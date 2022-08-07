using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;

 public class end : MonoBehaviour {

   public void RestartLevel(){
     SceneManager.LoadScene("Finish");
   }
   Rigidbody2D rb;
   void Start()
   {
     //GetComponent<Collider> ().enabled = true;
rb=GetComponent<Rigidbody2D>();
   }



     void OnCollisionEnter2D(Collision2D other)
       {
         float f;
             f = 0.2f;
         if (other.gameObject.tag=="hero"){
           rb.velocity=Vector2.zero;

           Invoke("RestartLevel", f);
         }
       }
 }
