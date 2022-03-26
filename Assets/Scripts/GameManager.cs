using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum Difficulty {easy, medium, hard };
public class GameManager : Singleton<GameManager>
{
    public int score;
    public int targetsRemaining;
    public Difficulty difficulty;
    public int countdownTimer;
    public TextMeshProUGUI timerDisplay;

    void Start()
    {
        StartCoroutine(CountDown());
        ChangeDifficulty(difficulty);
    }


    void Update()
    {
        targetsRemaining = TargetManager.instance.listofTargets.Count;
        UIManager.instance.targetsText.text = "Targts Remaining: " + targetsRemaining;
    }

    public void AddScore(int addpoints)
    {
        score += addpoints;
        UIManager.instance.scoreText.text = "Score: " + score;
        

    }


    public void ChangeDifficulty(Difficulty set)
    {
        difficulty = set;
        UIManager.instance.difficultyText.text = "Difficulty: " + difficulty;
    }

    IEnumerator CountDown()
    {
        while(countdownTimer > 0)
        {
            timerDisplay.text = countdownTimer.ToString();

            yield return new WaitForSeconds(1f);

            countdownTimer--;

        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag ("StaticTarget"))
        {
            countdownTimer += 5;
        }
    }

}
