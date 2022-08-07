


using UnityEngine;

public class screen : MonoBehaviour
{


    void Awake()
    {
      Screen.sleepTimeout = SleepTimeout.NeverSleep;

    }
}
