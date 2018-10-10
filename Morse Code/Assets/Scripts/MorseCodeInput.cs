using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MorseCodeInput : MonoBehaviour {

    public InputField MorseCodes;


    List<string> MorseKey_lv1 = new List<string> {"E","T"};
    List<string> MorseKey_lv2 = new List<string> {"A", "I","M","N"};
    List<string> MorseKey_lv3 = new List<string> {"G","K","O","R","S","U","W"};
    List<string> MorseKey_lv4 = new List<string> {"B","C","D","F","H","J","L","P","Q","V","X","Y","Z"};

    public GameObject MoveThis;

    private void FixedUpdate()
    {
        if (MorseCodes.text == RandText.RandList[0])
        {
            MoveThis.GetComponent<Rigidbody>().AddForce(-10, 0, 30);
        }

        if (MorseCodes.text == RandText.RandList[1])
        {
            MoveThis.GetComponent<Rigidbody>().AddForce(0, 0, 30);

        }
        if (MorseCodes.text == RandText.RandList[2])
        {
            MoveThis.GetComponent<Rigidbody>().AddForce(10, 0, 30);

        }

    }



}
