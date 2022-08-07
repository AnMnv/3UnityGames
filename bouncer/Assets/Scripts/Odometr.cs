using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Odometr: MonoBehaviour
{
  private float oldPos;
  void Start()
  {
  oldPos = this.gameObject.transform.position.y;
  }

  [SerializeField] Text test;
void Update()
{
  var nowPos = this.gameObject.transform.position.y;
    if(nowPos > oldPos)
        {
        test.text = nowPos.ToString();
        oldPos = nowPos;
        }
    else test.text = oldPos.ToString();
//test.text = (this.transform.position.y).ToString();
}
}
