using UnityEngine;

public class ExplosiveBarrel : MonoBehaviour
{
    public float explosionForceThreshold = 10f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            float impactForce = collision.relativeVelocity.magnitude;
            if (impactForce > explosionForceThreshold)
            {
                Destroy(collision.gameObject);
                Debug.Log("Игрок уничтожен взрывом!");
            }
        }
    }
}