using UnityEngine;
using System.Collections;

public class Stop : MonoBehaviour {
	Manager mnj;
	// Use this for initialization
	void Start () 
	{
		mnj = (Manager)GameObject.Find ("hexagon").GetComponent<Manager> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!mnj.flag)
		{
			Destroy(this.gameObject);
		}
	}
}