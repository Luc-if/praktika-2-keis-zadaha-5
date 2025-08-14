using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public int damageAmount = 25;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Здоровье игрока: " + health);
        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Игрок уничтожен из-за низкого HP!");
        }
    }
}