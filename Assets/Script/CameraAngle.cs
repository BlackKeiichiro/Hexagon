using UnityEngine;
using System.Collections;
using System;
public class CameraAngle : MonoBehaviour {
	public GameObject obj;
	public float rad;
	public float angle = 0.0f;
	float SpawnTime = 0;
	float interval = 1;
	float pm = 0.01f;
	public int c = 0;
	public int account = 0;
	public float accomp = 0.0f;
	public int countM = 12;
	Manager mnj;
	public bool acflag = false;
	// Use this for initialization

	void Start () 
	{
		mnj = (Manager)GameObject.Find ("hexagon").GetComponent<Manager> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (mnj.flag) {
			c = mnj.count;
			accomp += Time.deltaTime;
			account = Convert.ToInt32 (accomp);
			if (SpawnTime < Time.timeSinceLevelLoad) {
					SpawnTime = Time.timeSinceLevelLoad + interval;
			}
			AngleChange (mnj.count);
			Vector3 pos = obj.transform.position;
			Vector3 cam = this.transform.position;
			transform.LookAt (pos);
			transform.position = new Vector3 (pos.x + Mathf.Cos (angle) * rad, cam.y, pos.z + Mathf.Sin (angle) * rad);
			angle += pm;
		}
	}

	void AngleChange(int count){
		if (count == 12 || count == 25 || count == 39 || count==49 || count ==71 || count ==74 || count == 110 || count == 160) {
			if(!acflag)
			{
				angle -= 0.16f;
				pm = -0.016f;
			}
			else if(acflag)
			{
				angle += 0.16f;
				pm = 0.016f;
			}
			if(account == 32){
				acflag = (!acflag);
				accomp = 0;
				account = 0;
			}
		}
	}
}
 