
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[SerializeField] private Text textscore = default;

[RequireComponent(typeof(Rigidbody2D))]
	public class Player : MonoBehaviour
	{
		Rigidbody2D rb;
	public float movementSpeed = 10f;
	//public GameObject point1;
	//public GameObject scoretxt;
	//private int score;
	float movement = 0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		movement = Input.GetAxis("Horizontal") * movementSpeed;



	}

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;

		//if(rb.tag == "point")

		//{
			//check = false;
		//	Debug.Log("+");
		//	score++;
	//		scoretxt.GetComponent<Text>().text = "" + score;
	//	}
	}
}
