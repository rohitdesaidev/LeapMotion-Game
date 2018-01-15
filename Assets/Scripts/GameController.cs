using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	private int score=0;

	public TextMesh scoreobj;
	void Start ()
	{
		score = 0;
		UpdateScore ();
//		StartCoroutine (ResetCubes ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore (int newScoreValue)
	{
		score++;
		UpdateScore ();
	}


	void UpdateScore ()
	{
		scoreobj.text = ""+score;
	}

	void ResetCubes ()
	{
		
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "ball") {
			AddScore (score);
			Debug.Log ("-----enter----" + score);
		}
	
	}
}
