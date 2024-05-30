using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public bool gameOver = false;
    private float startDelay = 2;
    private float repeatRate = 3;
    public TextMeshProUGUI gameOverText;
    private PlayerControl playerCS;
    private float score = 0;
    public TextMeshProUGUI scoreText;
    private float scoreIncreaseRate = 1;
    // Start is called before the first frame update
    void Start()
    {
        playerCS = GameObject.Find("Player").GetComponent<PlayerControl>();
        isGameActive = true;
        UpdateScore();
        StartCoroutine(IncreaseScoreOverTime());
    }
    private IEnumerator IncreaseScoreOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(scoreIncreaseRate);
            score++;
            UpdateScore();
        }
    }
    // Update is called once per frame
    void UpdateScore()
    {
        scoreText.text = $"Score: {score}";
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }
}