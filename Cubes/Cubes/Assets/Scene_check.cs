using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_check : MonoBehaviour
{
    // Start is called before the first frame update
    public static Scene scene;
    static void Start()
    {scene = SceneManager.GetActiveScene();
    Debug.Log("Active Scene is '" + scene.name + "'.");}

    void ProverkaScene()
    {
      if(scene.name == "Level_1")
      { Debug.Log("scene.name"); }
    }


}
