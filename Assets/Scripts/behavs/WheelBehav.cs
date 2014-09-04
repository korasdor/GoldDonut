using UnityEngine;
using System.Collections;
using Holoville.HOTween;

public class WheelBehav : MonoBehaviour {

	GameObject outerWheelObj;
	GameObject innerWheelObj;

	bool IsSpin = false;

	float distance;
	float speed = 0.095f;


	public void Init ()
	{
		outerWheelObj = gameObject.transform.Find("outerWheel").gameObject;

		innerWheelObj = gameObject.transform.Find("innerWheel").gameObject;
	}

	public void SpinWheel ()
	{
//		TweenParms tParams = new TweenParms ();
//		tParams.Prop ("");
//
//
//		HOTween.To (outerWheelObj.transform, 0.5f, tParams);

//		gameObject.transform.rotation = Quaternion.Slerp


		if (IsSpin == false) {
			IsSpin = true;
			distance = Random.Range (5000, 20000);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (IsSpin == true) {

			distance *= 0.95f;
			transform.RotateAround (gameObject.transform.position, Vector3.back, distance * Time.deltaTime);

			if (distance < 0.1f) {
				IsSpin = false;
				distance = 10000.0f;
			}
		}
	}
}
