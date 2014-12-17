using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GUIScoreTime : MonoBehaviour {
	Manager mnj;
	Text guitxt;
	// Use this for initialization
	void Start () {
		mnj = (Manager)GameObject.Find ("hexagon").GetComponent<Manager> ();
		guitxt = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		guitxt.text = "TIME:" + mnj.count;
		if (!mnj.flag)
		{
			guitxt.text ="";

			guitxt.text = "YOUR SCORE : " + mnj.count.ToString();
		}
	}
}
