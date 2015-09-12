using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {
    public LevelManager levelManager;
	void OnCollisionEnter2D(Collision2D collision)
	{
	 print ("Collision");
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
	 print ("Trigger");
	 levelManager.LoadLevel("Win Screen");
	}
}
