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
		    instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
}
