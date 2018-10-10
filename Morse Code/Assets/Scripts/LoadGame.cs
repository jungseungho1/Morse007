using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour {

    public string levelToLoad;
    public Color loadToColor = Color.black;

	void Update () {
        if (Input.GetMouseButtonDown(0))
            Initiate.Fade(levelToLoad, loadToColor, 3.0f);
	}
}
