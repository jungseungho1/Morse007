using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    private Vector3 axis;
    public float rotateSpeed;

    void Start()
    {
        axis = new Vector3(0f, 1f, 0f);
    }

    void FixedUpdate()
    {
        this.transform.Rotate(axis, Time.deltaTime * rotateSpeed);
    }
}
