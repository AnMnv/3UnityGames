using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (transform.position.x < -2.7)
        transform.position = new Vector3 (transform.position.x + 6f, transform.position.y, transform.position.z);
        else if (transform.position.x > 2.7)
        transform.position = new Vector3 (transform.position.x - 6f, transform.position.y, transform.position.z);

    }
}
