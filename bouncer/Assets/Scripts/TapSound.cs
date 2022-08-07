using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TapSound : MonoBehaviour
{

  public AudioSource audio;
  public AudioClip klik;

public void ClickSound()
{
  audio.PlayOneShot(klik, 0.7F);
}

}
