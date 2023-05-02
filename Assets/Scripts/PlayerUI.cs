using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text livesText;

    private void Start()
    {
        scoreText.text = Goal.score.ToString();
        livesText.text = GameManager.lives.ToString();
    }
    public void UpdateScore()
    {
        scoreText.text = Goal.score.ToString();
    }
    public void UpdateLives()
    {
        livesText.text = GameManager.lives.ToString();
    }
}
