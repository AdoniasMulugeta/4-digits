using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessScorer : Singleton <GuessScorer>{

    public Guess ScoreGuess(Guess guessedValue) {
        List<string> correct = new List<string>();
        correct.Add("1");
        correct.Add("2");
        correct.Add("3");
        correct.Add("4");
        for (int i=0; i < guessedValue.value.Length; i++) {
            string val = guessedValue.value[i].ToString();
            if (correct.Contains(val))
            {
                guessedValue.correctValue++;
            }
            if(correct.IndexOf(val) == i)
            {
                guessedValue.correctPosition++;
            }
        }
        return guessedValue;
    }
}
