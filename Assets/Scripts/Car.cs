using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigiBody;

    private float speed;
    [SerializeField] private float minSpeed = 1f;
    [SerializeField] private float maxSpeed = 7.5f;


    void Awake()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        Destroy(gameObject, 5f);
    }
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rigiBody.MovePosition(rigiBody.position + forward * speed * Time.fixedDeltaTime);
    }
}
