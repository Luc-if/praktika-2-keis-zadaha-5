using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public int damageOnHit = 25;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageOnHit);
            }
        }
    }
}