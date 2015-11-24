using UnityEngine;
using System.Collections;

public class rotateSphere : MonoBehaviour {

	[SerializeField] private float speedY;
	private bool onRotate;


	// Use this for initialization
	void Start () {
		speedY = 5f;
		onRotate = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Cardboard.SDK.Triggered) {
			if(onRotate){
				onRotate = false;
			}
			else{
				onRotate = true;
			}
		}
		if (onRotate) {
			transform.Rotate (new Vector3 (0, speedY, 0) * Time.deltaTime);
		}
	}
}
