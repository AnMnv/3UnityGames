using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pole : MonoBehaviour
{

  public GameObject yes_thorns;
  public GameObject no_thorns;
  public GameObject vrag;
  public GameObject vrag2;
  public void Start()
    {
      //anime = GetComponent<Animator>();
    //  yes_thorns.SetActive(false);
    //  no_thorns.SetActive(false);
    }
    IEnumerator StartA(GameObject obj)
      {
        no_thorns.SetActive(true);
        vrag.SetActive(false);
      yield return new WaitForSeconds(5f);
      obj.SetActive(true);
      no_thorns.SetActive(false);
      vrag.SetActive(true);
      yes_thorns.SetActive(true);
      yield return new WaitForSeconds(1f);
      yes_thorns.SetActive(false);
      }
      
    IEnumerator StartB(GameObject objj)
      {
        no_thorns.SetActive(true);
        vrag2.SetActive(false);
      yield return new WaitForSeconds(5f);
      objj.SetActive(true);
      no_thorns.SetActive(false);
      vrag2.SetActive(true);
      yes_thorns.SetActive(true);
      yield return new WaitForSeconds(1f);
      yes_thorns.SetActive(false);
      }

    //IEnumerator StartC()
    //  {
    //  no_thorns.SetActive(true);
    //  vrag.SetActive(false);
      //vrag2.SetActive(false);

      //yield return new WaitForSeconds(5f);
      //no_thorns.SetActive(false);
      //vrag.SetActive(true);
    //  vrag2.SetActive(true);

      //yes_thorns.SetActive(true);
      //yield return new WaitForSeconds(1f);
      //yes_thorns.SetActive(false);
    //  }


        void OnTriggerEnter2D(Collider2D other)
          {
            if (other.gameObject.tag=="shield")
            {
              var objects = GameObject.FindGameObjectsWithTag("vrag");
              foreach(GameObject obj in objects)
              {
              obj.SetActive(false);
              StartCoroutine(StartA(obj));
              }

              var objectss = GameObject.FindGameObjectsWithTag("spook");
              foreach(GameObject objj in objectss)
              {
              objj.SetActive(false);
              StartCoroutine(StartB(objj));
              }


              //StartCoroutine(StartC());


            }
          }


}

//private GameObject inst_obj;

//void Start () {
  //int rand = Random.Range (0, objects.Length - 1);
  //inst_obj = Instantiate (objects[rand], objects[rand].transform.position, Quaternion.identity) as GameObject;
  //inst_obj.transform.localScale = new Vector3 (0.25f, 0.25f, 0.25f);
