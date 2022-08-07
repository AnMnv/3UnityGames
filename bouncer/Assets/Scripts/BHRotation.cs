using UnityEngine;
using System.Collections;

public class BHRotation : MonoBehaviour{
public float engle;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, engle) * Time.deltaTime);
    }
}
