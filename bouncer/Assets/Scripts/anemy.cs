using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anemy : MonoBehaviour
{


  int Life=100;
    // Start is called before the first frame update
    void Start()
    {

    }

void OnCollisionEnter2D(Collision2D shit)
  {

    if (shit.gameObject.tag == "anemy"){
  //Invoke("Reload", 1);
  Life--;
}
void OnGUI(){
  GUI.Box(new Rect(0,0,100,30), "Life= " + Life);
}

void Reload(){
  Application.LoadLevel(Application.loadedLevel);
}



}
}
