using UnityEngine;
using System.Collections;

namespace CreateObj{
	public class CreateObj : MonoBehaviour{
		Vector3 vec = new Vector3(0,-37,0);
		public void CreateControl(int count){

		}
		
		void CreateObject(GameObject[] prefub ,int num){
			Instantiate (prefub[num], vec, Quaternion.identity);
		}
		
		void StartCreateObject(GameObject[] stprefub ,int num){
			Instantiate (stprefub[num], vec, Quaternion.identity);
		}
	}
}
