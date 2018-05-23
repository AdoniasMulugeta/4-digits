using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitPicker : MonoBehaviour {
    Button digitButton;
    
	// Use this for initialization
	void Start () {
        if(LevelManager.Instance.currentLevel.type == Level.DigitType.NUMBER)
        {

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
