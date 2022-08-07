using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interface : MonoBehaviour {


    private bool isPaused = false;
    public GameObject pp;



    void Update ()
    {

        //Пауза
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
            {
            pp.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
            }

            else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
                {
                pp.SetActive(false);
                Time.timeScale = 1;
                isPaused = false;
                }
	}
  
    public void pauseOn()

      {
      pp.SetActive(true);
      Time.timeScale = 0;
      isPaused = true;
      }

      public void _continue()
        {
        pp.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
        }

        public void gotomenu()
            {
            Time.timeScale = 1;
            SceneManager.LoadScene("Main Menu");
            }
}
