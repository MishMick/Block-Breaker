using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

    private int maxHits;
    private int timesHits;
    private LevelManager levelmanager;
	private bool isBreakable;
	
    public Sprite[] hitSprites;
    public static int breakAbleCount = 0;
	// Use this for initialization
	void Start () 
	{
	  timesHits = 0;
	  levelmanager = GameObject.FindObjectOfType<LevelManager>();
	  isBreakable = (this.tag == "Breakable");
	  //Keep track of bricks
	  if(isBreakable)
	  {
	   breakAbleCount++;
	  }
	}
	
	// Update is called once per frame
	void Update () 
	{
	  
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
	  if(isBreakable)
	  {
	  HandleHits ();
	  }
	}
	void HandleHits()
	{
		timesHits++;
		maxHits = hitSprites.Length + 1;
		if(timesHits >= maxHits)
		{
		    breakAbleCount--;
		    levelmanager.BrickDestroyed();
			Destroy(gameObject);
		}
		else
		{
			LoadSprites();	
		}
	}
	//TODO remove this method once we win
	void SimulateWin()
	{
	 levelmanager.LoadNextLevel();
	}
	void LoadSprites()
	{
	 int spriteIndex = timesHits - 1;
	 if(hitSprites[spriteIndex])
	 this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
	}
}
