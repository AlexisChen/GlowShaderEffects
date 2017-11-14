using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatAnim : MonoBehaviour {
	//user inputs
	public float degreesPerSecond = 15.0f;
	public float amplitude = 0.5f;
	public float frequency = 1f;

	//Position Storage Variables
	Vector3 posOffset = new Vector3();
	Vector3 tempPos = new Vector3();

	//for material
	Material mGlowMaterial;
	float mStart = 0.7f;
	float rimPower;

	// Use this for initialization
	void Start () {
		
		posOffset = transform.position;
		mGlowMaterial = GetComponent<Renderer>().material;
	}
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0f, Time.deltaTime*degreesPerSecond, 0f), Space.World);

		tempPos = posOffset;
		tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency)*amplitude;
		transform.position = tempPos;

		rimPower = mStart +Mathf.Sin (Time.fixedTime * Mathf.PI*frequency);
		mGlowMaterial.SetFloat ("_RimPower", rimPower);
	}
}
