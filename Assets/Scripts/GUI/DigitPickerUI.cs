using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitPickerUI : MonoBehaviour {

    private Text digitButtonText;
    private string digit;
    void Start() {
        digit = GetComponentInChildren<Text>().text; 
    }
    public void OnDigitButtonClick() {
        
    } 
}
