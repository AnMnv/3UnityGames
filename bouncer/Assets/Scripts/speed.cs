using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
  Vector3 oldPos;

float totalDistance = 2.0f;
float speedMove = 100.0f;

void Start()
{
  oldPos = transform.position;
}


void Update()
{
  totalDistance += (transform.position - oldPos).magnitude;
  oldPos = transform.position;

  if (totalDistance > 1.0f)
  {
      speedMove += (int)totalDistance * 2.0f;
      totalDistance -= (int)totalDistance;
  }
}

}
