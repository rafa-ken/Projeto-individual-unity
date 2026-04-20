using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource audio;
    public float speed = 8f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        if (GameController.gameover)
        {
            rb.linearVelocity = Vector2.zero;
            return;
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        if (movement.magnitude > 1f)
            movement.Normalize();

        rb.linearVelocity = movement * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coletavel") && other.gameObject.activeSelf)
        {
            audio.Play();
            GameController.Collecte();
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}   