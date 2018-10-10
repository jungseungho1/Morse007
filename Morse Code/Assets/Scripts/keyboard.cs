using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard : MonoBehaviour {
    
    public Material successMat;
    public GameObject particles;
    public string keys;

    public bool success = false;

    void Start()
    {
        particles.SetActive(false);
    }

    void Update()
    {
        if (!success && Input.GetKey(keys))
        {
            Debug.Log("success");
            success = true;
            particles.SetActive(true);
            GetComponent<Renderer>().material = successMat;
        }
    }

    //void OnGUI()
    //{
    //    TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    //}
}
