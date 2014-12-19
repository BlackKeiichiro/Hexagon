using UnityEngine;
using System;
using System.Collections;

public class Manager : MonoBehaviour {
	public int count = 0;
	public float comp = 0.0f;
	public float sclch = 8;
	public float duration = 8.0f;
	public float interval = 1.5f;
	public float unirota = 3.6f;
	public int uniangle = 180;
	public bool flag = true;
	public GameObject obj;
	public GameObject end;
	public AudioSource audios;
	// Use this for initialization
	void Start () {
		GameObject canvas = GameObject.Find("Canvas") as GameObject;
		obj =  canvas.transform.FindChild("Button").gameObject;
		end =  canvas.transform.FindChild("Button1").gameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!flag){
			obj.SetActive(true);
			end.SetActive(true);
		}
	}
	public void Restart(){
		Application.LoadLevel("Gamenew");
	}
	public void StartMenu(){
		Application.LoadLevel("Start");
	}
}
