using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detroy : MonoBehaviour
{
      public Transform kivi;

      void Update()
      {
          if(kivi.position.y > transform.position.y)
          {
            Destroy(gameObject, 10f);
          }

      }
}
