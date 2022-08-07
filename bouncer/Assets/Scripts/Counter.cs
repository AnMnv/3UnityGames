using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
  //public static GameController instance;
  public static Counter instance;
  public Text score, bestscore;
  int scoreCounter, bestscoreCounter;


  private BoxCollider2D point1;
  private CircleCollider2D player;


  void Awake()
      {
        instance = this;
      }

    void Start()
    {
      GameObject m = GameObject.Find("mainhero");
      point1 = GetComponent<BoxCollider2D>();
      //player = GetComponent<CircleCollider2D>();
      player = m.GetComponent<CircleCollider2D>();
    }


    void Update()
    {
      score.text = "Score" + scoreCounter;
      bestscore.text = "BestScore" + bestscoreCounter;


      if (point1.IsTouching(player))
      {
        instance.AddScore();
        BestScore();
        //bestscoreCounter++;
        Destroy(gameObject);
      }

    }

    public void AddScore()
    {scoreCounter++;}

      public void BestScore()
      {
        if(scoreCounter>=bestscoreCounter)
        {
            bestscoreCounter=scoreCounter;
        }
      }
}
