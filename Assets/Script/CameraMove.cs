using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public GameObject maincamera;
	public float angle;
	public float rds = 11.0f;
	int count = 0;
	public bool flag;
	Vector3 center,pos,r,direction;
	
	void Update () {
		count++;
		if (flag) {
			center = new Vector3 (3.0f, -10.0f, 97.0f);
			r = Vector3.right * rds;
			direction = Vector3.up;
			if (count > 0){
				angle += Time.deltaTime * 100 % 360;
				pos =Quaternion.AngleAxis (angle, direction) * r;
				maincamera.transform.position = pos+center;
			}
		}
	}
}
