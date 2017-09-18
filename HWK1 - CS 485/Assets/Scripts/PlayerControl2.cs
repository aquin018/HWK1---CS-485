using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerControl2 : MonoBehaviour {

	public float speed;
	public Text gameOver;
	public Text winText;

	private Rigidbody rb;
	private int lose;
	private int win;
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		lose = 1;
		win = 1;
		SetGameOver ();
		gameOver.text = "";
		SetWinText ();
		winText.text = "";
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement*speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("GroundO"))
		{
			other.gameObject.SetActive (false);
			lose = 0;
			SetGameOver ();
		}

		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			win = 0;
			SetWinText ();
		}
	}

	void SetGameOver()
	{
		
		if(lose == 0)
			{
			gameOver.text = "Game Over!! You Fell.";
			} 
	}
	void SetWinText ()
	{
		if(win == 0)
		{
			winText.text = "You Make it! Nice Job";
		}
	}
}
