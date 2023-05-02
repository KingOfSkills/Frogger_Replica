using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static string playerName;
    private WriteScores writeScores;
    private PlayerUI playerUI;

    void Start()
    {
        writeScores = FindObjectOfType<WriteScores>();
        playerUI = FindObjectOfType<PlayerUI>();
        if (SceneManager.GetActiveScene().name == "Play")
        {
            if (playerName == null)
            {
                playerName = "Player";
            }
        }
    }
    public void UpdatePlayerName(string name)
    {
        playerName = name;
    }    
    public void LoseLife()
    {
        lives -= 1;
        playerUI.UpdateLives();
        if (lives <= 0)
        {
            writeScores.AddNewScore();
            SceneManager.LoadScene("Credits");
        }
    }
}
