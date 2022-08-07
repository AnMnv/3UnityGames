using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PouseColours : MonoBehaviour
{
  public Sprite a , b;


  void OnMouseDown()
    {
      GetComponent<SpriteRenderer>().sprite = a;
    }

  void OnMouseUp()
    {
      GetComponent<SpriteRenderer>().sprite = b;
    }




}
