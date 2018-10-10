using UnityEngine;

using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RandText : MonoBehaviour
{
    List<string> Alphabet = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

    public static List<string> RandList;
    public static List<int> RandNum;


    public GameObject text0;
    public GameObject text1;
    public GameObject text2;

    public GameObject symbol0;
    public GameObject symbol1;
    public GameObject symbol2;

    Sprite[] sprites;


    void Awake()
    {
        sprites = Resources.LoadAll<Sprite>("sprites");

        TextMesh textMesh0 = text0.GetComponent<TextMesh>();
        TextMesh textMesh1 = text1.GetComponent<TextMesh>();
        TextMesh textMesh2 = text2.GetComponent<TextMesh>();

        SpriteRenderer SpriteRenderer0 = symbol0.GetComponent<SpriteRenderer>();
        SpriteRenderer SpriteRenderer1 = symbol1.GetComponent<SpriteRenderer>();
        SpriteRenderer SpriteRenderer2 = symbol2.GetComponent<SpriteRenderer>();

        RandGenerator();

        textMesh0.text = RandList[0];
        textMesh1.text = RandList[1];
        textMesh2.text = RandList[2];
       
        SpriteRenderer0.sprite = sprites[RandNum[0]];
        SpriteRenderer1.sprite = sprites[RandNum[1]];
        SpriteRenderer2.sprite = sprites[RandNum[2]];

    }


    void Update()
    {

        TextMesh textMesh0 = text0.GetComponent<TextMesh>();
        TextMesh textMesh1 = text1.GetComponent<TextMesh>();
        TextMesh textMesh2 = text2.GetComponent<TextMesh>();

        SpriteRenderer SpriteRenderer0 = symbol0.GetComponent<SpriteRenderer>();
        SpriteRenderer SpriteRenderer1 = symbol1.GetComponent<SpriteRenderer>();
        SpriteRenderer SpriteRenderer2 = symbol2.GetComponent<SpriteRenderer>();

        if (PointSystem.destroyed == true)
        {
            RandGenerator();
            PointSystem.destroyed = false;
        }


        textMesh0.text = RandList[0];
        textMesh1.text = RandList[1];
        textMesh2.text = RandList[2];

        SpriteRenderer0.sprite = sprites[RandNum[0]];
        SpriteRenderer1.sprite = sprites[RandNum[1]];
        SpriteRenderer2.sprite = sprites[RandNum[2]];

    }

    void RandGenerator()
    {
        int Rand;
        int RandListLength = 3;

        RandList = new List<string>(new string[RandListLength]);
        RandNum = new List<int>(new int[RandListLength]);

        for (int j = 0; j < RandListLength; j++)
        {
            Rand = Random.Range(0, 26);
            if (RandList.Contains(Alphabet[Rand]))
            {
                Rand = Random.Range(0, 26);
            }
            RandList[j] = Alphabet[Rand];
            RandNum[j] = Rand;

        }
        //Debug.Log("1: " + RandList[0] + ",\t2: " + RandList[1] + ",\t3: " + RandList[2]);
    }
}