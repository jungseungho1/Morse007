using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour {

    public string tiltLeft;
    public string tiltRight;
    public float speed;

    void FixedUpdate()
    {
        if (Input.GetKey(tiltLeft))
        {
            this.GetComponent<Rigidbody>().AddForce(-speed, 0, 0);
        }
        if (Input.GetKey(tiltRight))
        {
            this.GetComponent<Rigidbody>().AddForce(speed, 0, 0);
        }
    }
}
