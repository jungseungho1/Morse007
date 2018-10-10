using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

    public Transform center;

	void FixedUpdate () {
        transform.LookAt(center);
	}
}
