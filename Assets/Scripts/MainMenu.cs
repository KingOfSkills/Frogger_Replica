using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private InputField playerName;

    private void Start()
    {
        GameManager.lives = 3;
        Goal.score = 0;
        playerName.text = GameManager.playerName;
    }
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Ouit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
