using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Level {
	public int digitLength;
	public int maxTries;
    public DigitType type;

	public enum DigitType{
	    NUMBER,NUMBER_AND_ALPHABET
	}
}
