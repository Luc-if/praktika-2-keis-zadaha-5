using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    public ParticleSystem movementParticles;

    private Rigidbody rb;

    void Start()
    {

        rb = GetComponent<Rigidbody>();

        gameObject.tag = "Player";
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);

        rb.velocity = movement * speed;


        if (movement.magnitude > 0.1f)
        {
            if (movementParticles != null && !movementParticles.isPlaying)
            {
                movementParticles.Play();
            }
        }
        else 
        {
            if (movementParticles != null && movementParticles.isPlaying)
            {
                movementParticles.Stop();
            }
        }
    }
}