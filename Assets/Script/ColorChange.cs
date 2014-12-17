using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {
	public bool flag = true;
	Manager mnj;
	float SpawnTime = 0;
	float interval = 1;
	// Use this for initialization
	void Start () {
		mnj = (Manager)GameObject.Find ("hexagon").GetComponent<Manager> ();
	}
	public float duration = 4.0f;
	public Color color0 = Color.red;
	public Color color1 = Color.yellow;
	void Update() {
		if (SpawnTime < Time.timeSinceLevelLoad) {
			SpawnTime = Time.timeSinceLevelLoad + interval;
			if(mnj.count == 68){
				color0 = Color.blue;
				color1 = Color.white;
			}
		}
		float t = Mathf.PingPong(Time.time, mnj.duration) / mnj.duration;
		light.color = Color.Lerp(color0, color1, t);
	}
}
