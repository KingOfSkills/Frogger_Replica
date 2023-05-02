using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public static int score = 0;

    [SerializeField] private GameObject playerUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score += 100;
        playerUI.GetComponent<PlayerUI>().UpdateScore();
        collision.transform.position = new Vector3(0, -3, 0);
    }
}
