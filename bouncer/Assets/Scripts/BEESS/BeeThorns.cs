using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeeThorns : MonoBehaviour
{

  public void RestartLevel()
  {
    SceneManager.LoadScene("GameOverBee");
  }

  void OnCollisionEnter2D(Collision2D a)
    {
          float f;
          f = 0.2f;
          if(a.gameObject.tag == "hero" && a.gameObject.transform.position.y > transform.position.y)
            {
            Invoke("RestartLevel", f);
            }

          if(a.gameObject.tag=="deadeye")
            {
            Destroy(gameObject, 5f);
            }
}
}
