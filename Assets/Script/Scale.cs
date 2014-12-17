using UnityEngine;
using System.Collections;

public class Scale : MonoBehaviour {

	public float sclch = 1.0f;
	public bool flag;
	
	// Update is called once per frame
	void Update () {
		if (flag == true) {
			this.transform.localScale -= new Vector3 (sclch, 0, sclch);
		}
	}
	void OnTriggerEnter() 
	{
		flag = false;
	}
}
