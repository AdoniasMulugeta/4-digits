using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomValueGenerator : MonoBehaviour {

    void Print(List<int> list) {
		print(list[0] +" "+ list[1] + " " + list[2] + " " + list[3]);
    }
	void Update(){
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Guess guess = GuessScorer.ScoreGuess(new Guess(generateNumbers(4, 0, 9)));
            print(guess.correctValue+" "+guess.correctPosition);
        }
	}

    string generateNumbers(int length, int min, int max) {
        List<int> usedNumbers = new List<int>();
        string generatedNumbers = "";
        max++;//Because Random.Range max is exclusive
        for (int i = 0; i < length; i++) {
            int number = Random.Range(min, max);
            while (usedNumbers.Contains(number))
            {
                number = Random.Range(min, max);
            }
            generatedNumbers += number;
			usedNumbers.Add (number);
        }
        print(generatedNumbers);
        return generatedNumbers;
    }
}
