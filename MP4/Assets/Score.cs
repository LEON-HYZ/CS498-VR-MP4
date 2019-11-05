using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text score = null;
    
    public static int scoreValue = 0;

    // Use this for initialization
    void Start () {
        if (!Menu.isTutorial) {
            score.text = "MyScore: 0";
        }
        
    }
	
	// Update is called once per frame
	void Update () {

        if (!GameOver.isGameOver && !Menu.isTutorial)
        {
            score.text = "MyScore: " + scoreValue;
        }
        
    }

}
