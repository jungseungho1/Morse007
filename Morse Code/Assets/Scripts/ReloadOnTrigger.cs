using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadOnTrigger : MonoBehaviour {

    public string levelToLoad;
    public Color loadToColor = Color.black;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Initiate.Fade(levelToLoad, loadToColor, 3.0f);
        }
    }
}
