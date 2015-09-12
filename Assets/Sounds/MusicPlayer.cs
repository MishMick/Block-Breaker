using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null;
	// Use this for initialization
	void Awake()
	{
	 Debug.Log("Music player awake:"+GetInstanceID());
		if(instance!=null)
		{
			Destroy (gameObject);
			print ("Deplicate music player self destruction");
		}
		else{
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	void Start () 
	{
	 Debug.Log("Music player start:"+GetInstanceID());
		
	
	}
	// Update is called once per frame
	void Update () {
	
	}
}
