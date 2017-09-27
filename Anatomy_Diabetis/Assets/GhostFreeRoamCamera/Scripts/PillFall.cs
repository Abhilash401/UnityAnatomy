using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillFall : MonoBehaviour {

	public Rigidbody myrigidbody;
	public void PillFalling(){
		myrigidbody = GetComponent<Rigidbody> ();
		myrigidbody.useGravity = true;
	}

}
