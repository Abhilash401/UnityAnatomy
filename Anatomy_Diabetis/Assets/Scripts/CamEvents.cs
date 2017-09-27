using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamEvents : MonoBehaviour {
	public Camera[] cams;

	public void camAnatomyMove(){
		cams [0].enabled = true;
		cams [1].enabled = false;
	}

	public void camPillMove(){
		cams [0].enabled = false;
		cams [1].enabled = true;
 	}

}
