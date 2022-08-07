using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BestScore : MonoBehaviour
{

  private Text bestscore;
  //private Text bestscore;
    // Start is called before the first frame update
    void Start()
      {
     bestscore = GetComponent<Text>();
     //bestscore.text = Info.bestscore.ToString();
      }

    void Update()
    {
        if( Info.bestscore<Info.score)
        {
          //PlayerPrefs.SetInt("BestScore", Info.bestscore);
        bestscore.text = Info.bestscore.ToString();
        }
          else
          {

          }
    }

}
