using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class successorAnim : MonoBehaviour {

	public GameObject successor;
	public float lifeSpan;
	float starttime; 
	float timeCounter;
	// Use this for initialization
	void Start () {
		timeCounter = 0f;

	}

	void OnEnable(){
		timeCounter = 0f;
	}

	void Update()
	{
		timeCounter += Time.deltaTime;
		if (timeCounter > lifeSpan)
		{
			gameObject.SetActive (false);
			successor.SetActive (true);
		}
	
	}

}