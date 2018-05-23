using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Guess {
    public string value;
    public int correctValue = 0;
    public int correctPosition = 0;
    public Guess(string newValue) {
        value = newValue;
    }
}
