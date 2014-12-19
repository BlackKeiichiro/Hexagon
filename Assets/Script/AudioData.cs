using UnityEngine;
using System.Linq;
using System.Collections;
public class AudioData : MonoBehaviour {

	private float[] wavedata = new float[1024];

	void Update()
	{
		AudioListener.GetOutputData(wavedata, 1);
		var volume = wavedata.Select(x => x*x).Sum() / wavedata.Max();
		volume = volume / wavedata.Length;
		transform.localScale = (Vector3.one *500.0f * volume + new Vector3(200f,0,200f));
	}

}