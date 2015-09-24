﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour 
{

	float mousePosInBlocks;
	static public bool autoplay = true;
	private Ball ball;
	
	// Use this for initialization
	void Start () 
	{
	  ball = Object.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	if(autoplay)
	  Autoplay();
	  else
	  MoveWithMouse();
	}
	
	void MoveWithMouse()
	{
		Vector3 paddlePos = new Vector3(0.5f,this.transform.position.y,0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x,0.5f,15.5f);
		this.transform.position = paddlePos;
		
		if(Input.GetTouch(0).phase == TouchPhase.Moved)
		{
		 Vector2 TouchDeltaPosition = Input.GetTouch(0).deltaPosition;
		 Vector3 paddlePosition = new Vector3(TouchDeltaPosition.x,this.transform.position.y,0f);
		 this.transform.position = paddlePosition;
		}
	}
	
	void Autoplay()
	{
		Vector3 paddlePos = new Vector3(0.5f,this.transform.position.y,0f);
		mousePosInBlocks = Input.mousePosition.x/Screen.width*16;
		paddlePos.x = Mathf.Clamp(mousePosInBlocks,0.5f,15.5f);
		this.transform.position = paddlePos;
	}
}
