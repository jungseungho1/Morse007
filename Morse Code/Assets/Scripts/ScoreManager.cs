using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScoreManager : MonoBehaviour
{
    public InputField MorseCodes;

    public static int score;
    public int scoreValue;

    List<string> MorseKey_lv1 = new List<string> { "E", "T" };
    List<string> MorseKey_lv2 = new List<string> { "A", "I", "M", "N" };
    List<string> MorseKey_lv3 = new List<string> { "G", "K", "O", "R", "S", "U", "W" };
    List<string> MorseKey_lv4 = new List<string> { "B", "C", "D", "F", "H", "J", "L", "P", "Q", "V", "X", "Y", "Z" };

   

    Text text;


    void Awake()
    {
        text = GetComponent<Text>();

        // Reset the score.
        score = 0;
    }


    void Update()
    {
        text.text = "Score: " + score;

        if (MorseKey_lv1.Contains(MorseCodes.text) || MorseKey_lv2.Contains(MorseCodes.text))
        {
            scoreValue = 3;
        }
        if (MorseKey_lv3.Contains(MorseCodes.text))
        {
            scoreValue = 5;
        }
        if (MorseKey_lv4.Contains(MorseCodes.text))
        {
            scoreValue = 7;

        }


        if (PointSystem.hit == true)
        {
            score += scoreValue;
            PointSystem.hit = false;
        }

    }
}