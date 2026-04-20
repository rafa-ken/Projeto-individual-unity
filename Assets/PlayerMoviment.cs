using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoviment : MonoBehaviour
{
    private Rigidbody2D rb;
    AudioSource audio;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "coletavel")
        {
            audio.Play();
            GameController.Collecte();
            Destroy(other.gameObject);
        }
    }
}
