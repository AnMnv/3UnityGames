using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredObject : MonoBehaviour
{
public  int healthDown;
// public  int healthUp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update(){

    }
    void OnTriggerEnter(Collider col){
      if(col.tag == "hero"){
        col.GetComponent<Health> ().health -= healthDown;
      }
    }
}
