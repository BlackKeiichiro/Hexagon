using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour {
	Manager mnj;
	Text guitxt;
	// Use this for initialization
	void Start () 
	{
		guitxt = gameObject.GetComponent<Text>();
		mnj = (Manager)GameObject.Find ("hexagon").GetComponent<Manager> ();
	}
	// Update is called once per frame
	void Update () 
	{
		if (!mnj.flag)
		{
			this.guitxt.text = "YOUR SCORE : " + mnj.count.ToString();
		}
	}
}
