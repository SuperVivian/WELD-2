using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Echange : MonoBehaviour {

	Vector3 starPosition;
	Vector3 maxPosition;

	public float changeX;
	public float changeMax;

	

	// Use this for initialization
	void Start () {
		starPosition = this.transform.position;


		changeX = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (changeX < changeMax)
		{

			changeX = this.transform.position.x - starPosition.x;

			maxPosition = this.transform.position;

		}
		else
		{
			changeX = changeMax;

			this.transform.position = maxPosition;


		}



		
		
	}
}
