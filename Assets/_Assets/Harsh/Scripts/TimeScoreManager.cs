using UnityEngine;
using TMPro;
using HarshData;

public class TimeScoreManager : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scorePerSecond = 10f;

    public int Score { get; private set; }

    private float scoreFloat;

    private void Update()
    {
        if (GameManager.instance.isGameEnd)
            return;

        scoreFloat += scorePerSecond * Time.deltaTime;

        int newScore = Mathf.FloorToInt(scoreFloat);

        if (newScore != Score)
        {
            Score = newScore;
            scoreText.text = "SCORE- "+Score.ToString();
        }
    }
}