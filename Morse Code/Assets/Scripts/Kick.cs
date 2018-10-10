using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour {

    public string keyZero;
    public string keyOne;
    public string keyTwo;
    public float speed;
    public float LR;

    void FixedUpdate()
    {
        if (Input.GetKey(keyZero))
        {
            this.GetComponent<Rigidbody>().AddForce(-LR, 0, speed);
        }
        if (Input.GetKey(keyOne))
        {
            this.GetComponent<Rigidbody>().AddForce(0, 0, speed);
        }
        if (Input.GetKey(keyTwo))
        {
            this.GetComponent<Rigidbody>().AddForce(LR, 0, speed);
        }
    }
}
