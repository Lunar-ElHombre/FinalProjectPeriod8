using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
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
            scoreText.text = $"Score: {score}";
    }
}
