using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager> {
    public List<Level> levels = new List<Level>();
    private int currentLevelIndex = 0;
    public Level currentLevel;
    void Start() {
        if(levels.Count > currentLevelIndex)
        {
            Level currentLevel = levels[currentLevelIndex];
            string guess = RandomValueGenerator.Instance.generateRandomNumbers(currentLevel.digitLength,0,9);
            print(guess);
            print(GuessScorer.Instance.ScoreGuess(new Guess(guess)));
        }
        else
        {
            print("No levels found");
        }
    }
}
