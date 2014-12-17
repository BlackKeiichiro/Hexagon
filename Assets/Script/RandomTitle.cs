using UnityEngine;
using System.Collections;

public class RandomTitle : MonoBehaviour {
	public int title;
	public string str;
	// Use this for initialization
	void Start () {
		switch((int)(Random.Range(0,3))){
		case 0:
			Instantiate(Resources.Load("title/genki"));
			break;
		case 1:
			Instantiate(Resources.Load("title/sawai"));
			break;
		case 2:
			Instantiate(Resources.Load("title/sikigami"));
			break;
		case 3:
			Instantiate(Resources.Load("title/genki"));
			Instantiate(Resources.Load("title/sawai"));
			Instantiate(Resources.Load("title/sikigami"));
			break;
		}
		//obj = Instantiate((GameObject)Resources.Load("title/genki"))as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
