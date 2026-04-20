using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed;
    private float distance;
    private Vector3 startPos;
    private float randomOffset;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
        randomOffset = Random.Range(0f, 100f);
        speed = Random.Range(2f, 5f);
        distance = Random.Range(1f, 2.5f);
    }

    void FixedUpdate()
    {
        if (GameController.gameover) return;

        float x = Mathf.Sin((Time.time + randomOffset) * speed) * distance;
        Vector2 newPos = new Vector2(startPos.x + x, startPos.y);
        rb.MovePosition(newPos);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}