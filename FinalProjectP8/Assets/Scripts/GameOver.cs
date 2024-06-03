using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
  public void setup(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = "GAMEOVER!";
    }
    public void Reset()
    {
        SceneManager.LoadScene("StarBorneOdessy");
    }
    
}
