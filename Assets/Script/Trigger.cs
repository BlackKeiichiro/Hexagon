﻿using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider coll)
	{
		if (coll.gameObject.tag == "Hexagon") 
		{
			coll.gameObject.tag = "h1";
		}
	}
}
