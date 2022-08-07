using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadBee : MonoBehaviour
{
  public void RestartLevel(){
    SceneManager.LoadScene("Bee");
  }
}
