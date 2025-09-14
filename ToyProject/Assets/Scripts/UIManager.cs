using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour {
    public Player player;
    
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;

    private void Update()
    {
        healthText.text = "체력: " + player.health.ToString();
        scoreText.text = "점수: " + player.score.ToString();
    }
}
