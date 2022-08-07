using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class tap : MonoBehaviour {

	public Sprite layer_green, layer_blue;

	void OnMouseDown () {
		GetComponent <SpriteRenderer> ().sprite = layer_blue;
	}

	void OnMouseUp () {
		GetComponent <SpriteRenderer> ().sprite = layer_green;
	}
  void OnMouseUpAsButton () {


		switch (gameObject.name) {
		case "PlayButton":
			Application.LoadLevel ("Bouncer");
			break;

			case "LevelsButton":
				Application.LoadLevel ("Bee");
				break;



		}
	}
}
