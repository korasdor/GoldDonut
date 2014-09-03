using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System;

public class ButtonBehav : MonoBehaviour {

	public event EventHandler<ButtonEventArgs> ButtonMouseDown;
	public event EventHandler<ButtonEventArgs> ButtonMouseUp;

	bool isPressed = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update() {

#if UNITY_ANDROID || UNITY_IPNONE
		if(Input.touchCount > 0){
			if (Input.GetTouch(0).phase == TouchPhase.Began) {
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
				RaycastHit hit;

				if (collider.Raycast(ray, out hit, 100.0f)) {

					if(isPressed == false) {
						OnMouseDown();
					}
				}
			}
		}

		if(Input.touchCount > 0){
			if (Input.GetTouch(0).phase == TouchPhase.Ended) {
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
				RaycastHit hit;
				
				if (collider.Raycast(ray, out hit, 100.0f)) {
					if(isPressed == true) {
						OnMouseUp();
					}
				}
			}
		}
#endif
	}

	void OnMouseDown() {
		isPressed = true;

		ButtonEventArgs eventArgs = new ButtonEventArgs();
		eventArgs.ButtonType = gameObject.name;

		ButtonMouseDown(this, eventArgs);
	}

	void OnMouseUp() {
		isPressed = false;

		ButtonEventArgs eventArgs = new ButtonEventArgs();
		eventArgs.ButtonType = gameObject.name;
		
		ButtonMouseUp(this, eventArgs);
	}
}
