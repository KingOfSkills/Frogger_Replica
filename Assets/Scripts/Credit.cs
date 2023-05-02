using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credit : MonoBehaviour
{
    [SerializeField] private Text playerName;

    private void Start()
    {
        playerName.text = GameManager.playerName;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
