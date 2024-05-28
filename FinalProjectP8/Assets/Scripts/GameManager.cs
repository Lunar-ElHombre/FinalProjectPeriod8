using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public bool gameOver =  false;
    public TextMeshProUGUI gameOverText;
    private PlayerControl playerCS;
    private float score = 0;
    public TextMeshProUGUI scoreText;
    private float scoreIncreaseRate = 1;
    // Start is called before the first frame update
    void Start()
    {
        
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
        if (gameOver)
        {
            scoreText.text = $"Score: {score}";
            return;
        }
            
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            GameManager.();
        }
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }

}
