using UnityEngine;
using System.Collections;
using System;

public class movehexagon : MonoBehaviour {
	
	Manager mnj;

	void Start()
	{
		mnj = (Manager)GameObject.Find ("hexagon").GetComponent<Manager> ();
	}

	void Update () {
		if (!mnj.flag)
			Destroy (this.gameObject);
		switch(mnj.count){
		case 7:
			mnj.sclch = 14;
			mnj.interval = 1.4f;
			mnj.duration = 4;
			mnj.unirota = 4.4f;
			mnj.uniangle = 220;
			break;
		case 12:
			mnj.sclch = 16;
			mnj.interval = 1.2f;
			mnj.duration = 4;
			mnj.unirota = 4.4f;
			mnj.uniangle = 220;
			break;
		case 69:
			mnj.sclch = 20;
			mnj.interval = 1.0f;
			mnj.duration = 1;
			mnj.unirota = 6.0f;
			mnj.uniangle = 300;
			break;
		}
		if (mnj.flag) 
		{
			this.transform.localScale -= new Vector3 (mnj.sclch, 0, mnj.sclch);
		}
	}

	void OnTriggerEnter(Collider coll) 
	{
		//print (coll.gameObject.name);
		if(coll.gameObject.tag == "MainHexagon"){
			Destroy(this.gameObject);
		}

	}
}