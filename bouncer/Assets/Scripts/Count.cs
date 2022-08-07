using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{

//private BoxCollider2D point1;
//private CircleCollider2D player;

void OnTriggerEnter2D(Collider2D a)
{
  if(a.gameObject.tag == "hero")
  {
    Info.score++;
    Info.bestscore++;
  //  PlayerPrefs.SetInt("BestScore", Info.bestscore);
    Destroy(gameObject);
  }
}



    // Start is called before the first frame update
  //  void Start()
//    {
//      GameObject m = GameObject.Find("mainhero");

//  point1 = GetComponent<BoxCollider2D>();
  //player = GetComponent<CircleCollider2D>();
    //player = m.GetComponent<CircleCollider2D>();
      //  }

    // Update is called once per frame
    //void Update()
    //{
      //if (point1.IsTouching(player))
    //  {
  //      Info.score++;
    //    Destroy(gameObject);
    //  }
  //  }
}
