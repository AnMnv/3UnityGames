using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class forvrag : MonoBehaviour
{

  public void RestartLevel(){
    SceneManager.LoadScene("GameOver");
  }
  Rigidbody2D rb;

  //bool muve=true;
    // Start is called before the first frame update
    void Start()
    {
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
