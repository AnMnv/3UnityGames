using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invicible : MonoBehaviour
{
//public GameObject heroi;
  public SpriteRenderer spriteRenderer;

  public void Start()
    {
    //heroi.SetActive(false);
    this.spriteRenderer = GetComponent<SpriteRenderer>();
    this.spriteRenderer.enabled = false;
    }

    //IEnumerator StartA(GameObject obj)
      //{
    //  this.spriteRenderer.enabled = true;
    //  yield return new WaitForSeconds(0.1f);
    //  obj.SetActive(true);
    //  this.spriteRenderer.enabled = false;
    //  }


    void OnCollisionEnter2D(Collision2D c)
      {
        if (c.gameObject.tag=="platforma")
        {
        //Debug.Log("Text: ");
          //  var objects = GameObject.FindGameObjectsWithTag("invisible");
      //  foreach(GameObject obj in objects)
        //{
        //obj.SetActive(false);
      //  StartCoroutine(StartA(obj));
        this.spriteRenderer.enabled = true;
        }

    }
    void OnCollisionExit2D(Collision2D ca)
    {
    this.spriteRenderer.enabled = false;
    }


  }
