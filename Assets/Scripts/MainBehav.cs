using UnityEngine;
using System.Collections;

public class MainBehav : MonoBehaviour {

	StartupService startup;

	// Use this for initialization
	void Start () {
		Screen.SetResolution(640, 1136, false);
		
		startup = new StartupService(this);
		startup.Init();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
