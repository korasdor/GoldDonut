using UnityEngine;
using System.Collections;
using System;
using AssemblyCSharp;

public class GameBehav : MonoBehaviour {

	public event EventHandler<EventArgs> PushButtonDown;
	public event EventHandler<EventArgs> SpinButtonDown;

	HeaderBehav headerBehav;
	WheelBehav wheelBehav;
	FooterBehav footerBehav;

	public void Init()
	{
		headerBehav = gameObject.transform.Find ("HeaderObj").gameObject.GetComponent<HeaderBehav>();
		headerBehav.Init ();

		wheelBehav = gameObject.transform.Find ("WheelObj").gameObject.GetComponent<WheelBehav>();
		wheelBehav.Init ();

		footerBehav = gameObject.transform.Find ("FooterObj").gameObject.GetComponent<FooterBehav>();
		footerBehav.SpinButtonDown += OnSpinButtonDown;
		footerBehav.PushButtonDown += OnPushButtonDown;
		footerBehav.Init ();
	}

	void OnSpinButtonDown (object sender, EventArgs e)
	{
		SpinButtonDown(sender, e);
	}

	void OnPushButtonDown (object sender, EventArgs e)
	{
		PushButtonDown(sender, e);
	}

	public void SpinWheel ()
	{
		wheelBehav.SpinWheel ();
	}
}