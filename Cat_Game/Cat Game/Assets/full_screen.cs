using UnityEngine;

public class FullScreenToggle : MonoBehaviour
{
  private bool _fullScreen;
  public bool fullScreen
  {
    set
    {
      _fullScreen = value;
      Screen.fullScreen = value;
    }
    get
    {
      return _fullScreen;
    }
  }

  private void Start()
  {
    fullScreen = Screen.fullScreen;
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.RightAlt) && Input.GetKeyDown(KeyCode.Return))
    {
      FullScreen();
    }
    else if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Return))
    {
      FullScreen();
    }
  }

  public void FullScreen()
  {
    if (fullScreen)
    {
      fullScreen = false;
    }
    else
    {
      fullScreen = true;
    }
  }
}