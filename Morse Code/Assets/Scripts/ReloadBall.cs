using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReloadBall : MonoBehaviour {
    
    public GameObject DestroyThis;
    public GameObject NewBall;
    public GameObject NewBallLoc;

    public InputField MorseCodes;

    bool reloaded = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            if (!reloaded)
            {
                Invoke("Reload", 2f);
                Invoke("DestoryBall", 3f);
                Invoke("clearField", 0.2f);
            }
        }
    }

    void Reload()
    {
        Instantiate(NewBall, NewBallLoc.transform.position, Quaternion.identity);
        reloaded = true;
    }

    void DestoryBall()
    {
        Destroy(DestroyThis);
    }

    void clearField()
    {
        MorseCodes.text = "";
    }
}
