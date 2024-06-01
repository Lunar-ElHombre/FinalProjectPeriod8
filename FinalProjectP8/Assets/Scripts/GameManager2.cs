using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager2 : MonoBehaviour
{
    public bool gameOver = false;
    public bool isGameActive;
    public TextMeshProUGUI gameOvertext;
    private float score = 0;
    public TextMeshProUGUI scoreText;
    private float scoreIncreaseRate = 1;
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GameOver()
    {
        isGameActive = false;
        gameOvertext.gameObject.SetActive(true);
    }
    private IEnumerator IncreaseScoreOverTime()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(scoreIncreaseRate);
            score++;
            UpdateScore();
        }
    }
    void UpdateScore()
    {
        scoreText.text = $"Score: {score}";
    }
}