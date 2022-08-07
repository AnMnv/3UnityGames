using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cerculiarka : MonoBehaviour
{
  public void RestartLevel()
    {
    SceneManager.LoadScene("GameOver");
    }

  void OnCollisionEnter2D(Collision2D c)
    {
      if(c.gameObject.tag == "hero")
      {
      Invoke("RestartLevel", 0.2f);
      }
          if (c.gameObject.tag=="deadeye")
          {
          Destroy(gameObject);
          }
    }
}
