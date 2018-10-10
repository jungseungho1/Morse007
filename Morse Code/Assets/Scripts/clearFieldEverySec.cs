using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clearFieldEverySec : MonoBehaviour {

    float elapsed = 0f;
    public InputField MorseCodes;

    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= 5f)
        {
            elapsed = elapsed % 1f;
            clearField();
        }
    }

    void clearField()
    {
        MorseCodes.text = "";
    }
}
