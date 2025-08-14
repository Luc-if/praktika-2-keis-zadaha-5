using UnityEngine;
using TMPro; // �� �������� ���������� ��� ����������!

public class PlayerWallet : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    private int coinsCount = 0;

    void Start()
    {
        UpdateCoinsText();
    }

    public void AddCoin(int amount)
    {
        coinsCount += amount;
        UpdateCoinsText();
    }

    void UpdateCoinsText()
    {
        if (coinsText != null)
        {
            coinsText.text = "Coins: " + coinsCount.ToString();
        }
    }
}