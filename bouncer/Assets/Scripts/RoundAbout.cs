using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundAbout : MonoBehaviour
{
    [SerializeField]
    Transform center;

    [SerializeField]
    float radius = 2f, angularspeed = 2f;
    float posX, posY, angle = 0f;


    void Update()
    {
        posX = center.position.x + Mathf.Cos(angle) * radius;
        posY = center.position.y + Mathf.Sin(angle) * radius;
        transform.position = new Vector2(posX, posY);
        angle = angle + Time.deltaTime * angularspeed;

        if (angle>=360f)
        {
          angle = 0f;
        }
    }
}
