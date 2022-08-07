using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
  public float speed = 90f;
  private Rigidbody2D rb;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

    void OnCollisionEnter2D(Collision2D cube)
    {
      if(cube.gameObject.tag == "wall")
      {
      rb.AddForce(new Vector2(Random.Range(-5.0f, 8.0f), Random.Range(-4.0f, 4.0f))*speed);
      }
    }

    void Sp()
    {
      if(speed > 100f)
      {
        speed = 100f;
        Debug.Log("sssssssssssssssss");
      }
    }
}
