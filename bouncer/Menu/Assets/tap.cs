using UnityEngine;
using System.Collections;

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
		case "Play":
			Application.LoadLevel ("Bouncer");
			break;
		}
	}
}
