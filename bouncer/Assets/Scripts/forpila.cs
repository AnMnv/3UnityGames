using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class forpila : MonoBehaviour
{

public void RestartLevel(){
    SceneManager.LoadScene("GameOver");
  }
  Rigidbody2D rb;

  //bool muve=true;
    // Start is called before the first frame update
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
      Destroy(gameObject, 5f);
      //  Info.score=0;
      Invoke("RestartLevel", f);
    }
    if (other.gameObject.tag=="deadeye"){
      //rb.velocity=Vector2.zero;
      Destroy(gameObject, 5f);

    }
  }
}
