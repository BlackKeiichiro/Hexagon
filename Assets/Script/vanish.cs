using UnityEngine;
using System.Collections;
using System;

public class vanish : MonoBehaviour {
	public bool flag = true;
	public GameObject[] obj;
	public int count = 0;
	public float comp = 0.0f;
	public int num = 1;
	float SpawnTime = 0;
	float interval = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		comp += Time.deltaTime;
		count = Convert.ToInt32(comp);
		this.transform.Rotate (0,num,0);
		if( SpawnTime < Time.timeSinceLevelLoad)
		{
			SpawnTime = Time.timeSinceLevelLoad + interval;	
			if(count % 5 == 0 && !flag)
			{
				Vanishing();
			}
		}
	}

	public void Vanishing()
	{
		//this.gameObject.SetActive ((flag)?false:true);
		this.gameObject.renderer.enabled = flag = ((flag) ? false : true);
	}
}
