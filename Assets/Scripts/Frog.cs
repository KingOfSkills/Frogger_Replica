using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody;
     private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) { rigidBody.MovePosition(rigidBody.position + Vector2.up); }
        if (Input.GetKeyDown(KeyCode.RightArrow)) { rigidBody.MovePosition(rigidBody.position + Vector2.right); }
        if (Input.GetKeyDown(KeyCode.DownArrow)) { rigidBody.MovePosition(rigidBody.position + Vector2.down); }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { rigidBody.MovePosition(rigidBody.position + Vector2.left); }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Car car))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            GetComponent<AudioSource>().Play();
            transform.position = new Vector3(0, -3, 0);
            gameManager.LoseLife();
        }
        //if (collision.TryGetComponent(out Goal goal))
        //{
        //    transform.position = new Vector3(0, -3, 0);
        //}
    }
}
