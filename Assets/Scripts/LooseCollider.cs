using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {
    private LevelManager levelManager;
	void Start () 
	{
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
	 print ("Collision");
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
	 print ("Trigger");
	 levelManager.LoadLevel("Lose Screen");
	}
}
