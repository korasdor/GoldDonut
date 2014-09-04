using UnityEngine;
using System.Collections;
using Holoville.HOTween;

public class HeaderBehav : MonoBehaviour {

	public void Init ()
	{
		TweenParms tParams = new TweenParms();
		tParams.Prop("position", new Vector3(0, 3.6f));

		HOTween.To(transform, 0.5f, tParams);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
