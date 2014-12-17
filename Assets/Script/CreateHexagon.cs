using UnityEngine;
using System.Collections;
using System;

public class CreateHexagon : MonoBehaviour {
	//public int count = 0;
	//public float comp = 0.0f;
	int num = 0;
	GameObject [,]hex;
	float SpawnTime = 0;
	Vector3 vec = new Vector3(0,-37,0);
	Quaternion rot;
	Manager mnj;
	int cnum = 0;

	void Start ()
	{
		mnj = (Manager)GameObject.Find ("hexagon").GetComponent<Manager> (); 
		this.transform.position =  vec;
		this.transform.localScale = new Vector3 (250,1000,250);
		hex = new GameObject[5, 3]
		{
			{(GameObject)Resources.Load("HEXAGON/hexagon1"),(GameObject)Resources.Load("HEXAGON/hexagon2"),(GameObject)Resources.Load("HEXAGON/hexagon3_1")}
			,{(GameObject)Resources.Load("HEXAGON/hexagon5"),(GameObject)Resources.Load("HEXAGON/hexagon7"),(GameObject)Resources.Load("HEXAGON/hexagon4")}
			,{(GameObject)Resources.Load("HEXAGON/partshexagon1"),(GameObject)Resources.Load("HEXAGON/partshexagon3"),(GameObject)Resources.Load("HEXAGON/partshexagon2")}
			,{(GameObject)Resources.Load("HEXAGON/hexagon3_1"),(GameObject)Resources.Load("HEXAGON/partshexagon1"),(GameObject)Resources.Load("HEXAGON/hexagon3_4")}
			,{(GameObject)Resources.Load("HEXAGON/hexagon4"),(GameObject)Resources.Load("HEXAGON/hexagon3_1"),(GameObject)Resources.Load("HEXAGON/hexagon4")}
		};
	}

	// Update is called once per frame
	void Update () 
	{
		if(mnj.flag)
		{
			mnj.comp += Time.deltaTime;
			mnj.count = Convert.ToInt32(mnj.comp);
					
			if( SpawnTime < Time.timeSinceLevelLoad)
			{
				SpawnTime = Time.timeSinceLevelLoad + mnj.interval;

				Instantiate (hex[cnum,num], vec, hex[cnum,num].transform.rotation);			
				if(num == 2)
				{
					cnum++; 
					if(cnum == 5)
					{
						cnum = 1;
					}	
				}
			num = (num==2)?0:++num;
			}
		}
	}
}