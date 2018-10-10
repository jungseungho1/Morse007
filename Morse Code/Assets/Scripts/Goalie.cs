using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalie : MonoBehaviour {

    public GameObject Spy;
    public bool SpyOn = false;

    public void GoalieOnOff()
    {
        if (SpyOn == false){
            Spy.SetActive(true);
            SpyOn = true;
        } else if (SpyOn == true){
            Spy.SetActive(false);
            SpyOn = false;
        }

    }

}
