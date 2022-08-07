using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class You_Win : MonoBehaviour
{

  public void WinLevel()
    {
      SceneManager.LoadScene("WinLevel");
    }

    void Update()
    {
      if(GameObject.FindGameObjectsWithTag("figure") == null)
      {
        {
        Invoke("WinLevel", 0.05f);
        }
      }
    }
}
