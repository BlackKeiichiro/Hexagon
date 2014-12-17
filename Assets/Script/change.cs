using UnityEngine;
using System.Collections;

public class change : MonoBehaviour {
	public void ChangScene(){
		Application.LoadLevel("Gamenew");
	}
	public void ExitGame(){
		Application.Quit();
	}
}
