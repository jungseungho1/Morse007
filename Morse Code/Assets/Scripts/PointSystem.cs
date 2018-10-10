using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour {

    public GameObject DestroyThis;
    public GameObject Kaboom;

    public static bool hit = false;
    public static bool destroyed = false;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {

            hit = true;
            Debug.Log("hit Wall");

            if (!destroyed)
            {
                Instantiate(Kaboom, DestroyThis.transform.position, Quaternion.identity);
                destroyed = true;
                //ScoreManager.score += scoreValue;
            }

            //Destroy(DestroyThis);
        }

    }
}
