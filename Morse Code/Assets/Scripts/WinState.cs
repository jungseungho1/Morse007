using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinState : MonoBehaviour {

    public int countdown = 0;
    public bool YouWin = false;

    public GameObject YouWinText;
    public Transform CreateHere;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ScoreManager.score >= 25 && !YouWin)
        {
            Instantiate(YouWinText, CreateHere.position, CreateHere.rotation);
            YouWin = true;
        }

	}
}
