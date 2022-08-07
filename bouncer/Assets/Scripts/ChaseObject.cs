using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseObject : MonoBehaviour
{
  public Vector2 direction;
  private Transform mainhero;
  public float acceleration = 100f;
  private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
      GameObject g = GameObject.Find("mainhero");
        mainhero = g.transform;
rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
transform.position= Vector3.MoveTowards(transform.position, mainhero.position, Time.deltaTime);
//rb.AddForce(direction.normalized * acceleration);
    }
}
