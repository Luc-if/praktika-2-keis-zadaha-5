using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerWallet playerWallet = other.GetComponent<PlayerWallet>();
            if (playerWallet != null)
            {
                playerWallet.AddCoin(1);
            }
            Destroy(gameObject);
        }
    }
}