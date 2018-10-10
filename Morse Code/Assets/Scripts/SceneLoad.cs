using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoad : MonoBehaviour {

    public string levelToLoad;
    public Color loadToColor = Color.black;
    public float timeToReset = 1.0f;

    public void reset()
    {
        Invoke("LoadScene", timeToReset);
            
    }

    void LoadScene()
    {
        Initiate.Fade(levelToLoad, loadToColor, 3.0f);
    }
}
