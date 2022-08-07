using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameCounter
  {
    public static int a = 10;
  }
public class lose_win : MonoBehaviour
{
  
[SerializeField]private string levelNameLose;
  public void Lose()
    {
    SceneManager.LoadScene(levelNameLose);
    }

[SerializeField]private string levelNameWin;
  public void Win()
    {
      SceneManager.LoadScene(levelNameWin);
    }


  void OnCollisionEnter2D(Collision2D c)
    {
      if(c.gameObject.tag == "orange")
        {
          GameCounter.a = 10;
          Handheld.Vibrate();// вибрация
          Invoke("Lose", 0.05f);
        }

      if(c.gameObject.tag == "figure")
        {
          Destroy(c.gameObject);
          --GameCounter.a;
        }

      //if(GameCounter.a == 0)
       // {  
         
       //   Invoke("Win", 5.05f);
       // }
    }


}
