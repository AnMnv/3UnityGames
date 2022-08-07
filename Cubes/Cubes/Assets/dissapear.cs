using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dissapear : MonoBehaviour
{
  public GameObject Block;

  public void Win()
    {
      SceneManager.LoadScene("Win");
    }

    void OnMouseDown()
      {
        Block.SetActive(!Block.activeSelf);
        --GameCounter.a;
            if(GameCounter.a == 0)
              {
                Invoke("Win", 1.05f);
              }
        }
}
