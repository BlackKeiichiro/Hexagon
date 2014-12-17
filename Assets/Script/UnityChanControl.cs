//
// Mecanimのアニメーションデータが、原点で移動しない場合の Rigidbody付きコントローラ
// サンプル
// 2014/03/13 N.Kobyasahi
//
using UnityEngine;
using System.Collections;

// 必要なコンポーネントの列記
[RequireComponent(typeof (Animator))]
[RequireComponent(typeof (CapsuleCollider))]
[RequireComponent(typeof (Rigidbody))]

public class UnityChanControl : MonoBehaviour
{
	public GameObject cube;
	public GameObject hex;
	public float angle;
	public float rds = 13.0f;
	bool turnflag = false;
	bool useCurves = true;
	Vector3 center,pos,r,direction;
	Manager mnj;
	public float animSpeed = 1.5f;				// アニメーション再生速度設定

	// キャラクターコントローラ（カプセルコライダ）の参照
	private CapsuleCollider col;
	//private Rigidbody rb;
	// キャラクターコントローラ（カプセルコライダ）の移動量
	private Vector3 velocity;
	// CapsuleColliderで設定されているコライダのHeiht、Centerの初期値を収める変数
	private float orgColHight;
	private Vector3 orgVectColCenter;
	
	private Animator anim;							// キャラにアタッチされるアニメーターへの参照

	// 初期化
	void Start ()
	{
		// Animatorコンポーネントを取得する
		anim = GetComponent<Animator>();
		mnj = (Manager)GameObject.Find ("hexagon").GetComponent<Manager> (); 
		col = GetComponent<CapsuleCollider>();
		orgColHight = col.height;
		orgVectColCenter = col.center;
	}
	
	
	// 以下、メイン処理.リジッドボディと絡めるので、FixedUpdate内で処理を行う.
	void FixedUpdate ()
	{
		if (mnj.flag) {
			anim.speed = animSpeed;								// Animatorのモーション再生速度に animSpeedを設定する
			center = new Vector3 (0.0f, -37.0f, 0.0f);
			r = Vector3.right * rds;
			direction = Vector3.up;
			if (Input.GetKey ("right")) 
			{
					anim.SetBool ("run_flag", true);
					angle += Time.deltaTime * mnj.uniangle % 360;//140:2.8
					transform.Rotate (0, mnj.unirota, 0);
					if (!turnflag) 
					{
						transform.Rotate (0, -180, 0);
						turnflag = true;
					}
					pos = Quaternion.AngleAxis (angle, direction) * r;
					cube.transform.position = pos + center;
			}
			else if (Input.GetKey ("left")) 
			{
					anim.SetBool ("run_flag", true);
					angle -= Time.deltaTime * mnj.uniangle % 360;
					transform.Rotate (0, -1.0f*mnj.unirota, 0);
					if (turnflag) {
						transform.Rotate (0, 180, 0);
						turnflag = false;
					}
					pos = Quaternion.AngleAxis (angle, direction) * r;
					cube.transform.position = pos + center;
			} else 
			{
				anim.SetBool ("run_flag", false);
			}
			if (useCurves)
			{
				resetCollider ();
			}
		}
	}

	void OnTriggerEnter(Collider col) 
	{
		if(col.gameObject.tag == "Hexagon"/* && mnj.flag*/)
		{
			mnj.flag = false;
			anim.SetBool("run_flag",false);
			//Application.LoadLevel("GameOver");
		}
	}

	void resetCollider()
	{
		// コンポーネントのHeight、Centerの初期値を戻す
		col.height = orgColHight;
		col.center = orgVectColCenter;
	}

}
