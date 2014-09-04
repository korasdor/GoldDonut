using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System;

public class FooterBehav : MonoBehaviour {

	public event EventHandler<EventArgs> PushButtonDown;
	public event EventHandler<EventArgs> SpinButtonDown;


	ButtonBehav pushButtonBehav;
	ButtonBehav spinButtonBehav;

	public void Init ()
	{
		pushButtonBehav = gameObject.transform.Find ("pushbutton").gameObject.GetComponent<ButtonBehav>();
		pushButtonBehav.ButtonMouseDown += OnButtonMouseDown;
		pushButtonBehav.ButtonMouseUp += OnButtonMouseUp;

		spinButtonBehav = gameObject.transform.Find ("spinbutton").gameObject.GetComponent<ButtonBehav>();
		spinButtonBehav.ButtonMouseDown += OnButtonMouseDown;
		spinButtonBehav.ButtonMouseUp += OnButtonMouseUp;


	}

	void OnButtonMouseDown (object sender, ButtonEventArgs e)
	{
		ButtonBehav currentObj = sender as ButtonBehav;

		if (currentObj == spinButtonBehav) {
			SpinButtonDown(sender, EventArgs.Empty);
		} else {
			PushButtonDown(sender, EventArgs.Empty);
		}
	}

	void OnButtonMouseUp (object sender, AssemblyCSharp.ButtonEventArgs e)
	{

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
