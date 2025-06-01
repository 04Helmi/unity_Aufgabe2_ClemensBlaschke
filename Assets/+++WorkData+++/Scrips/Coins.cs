using UnityEngine;

public class Coins : MonoBehaviour
{
    public int coinCounter;
    [SerializeField] UIManager manager;
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Coin"))
        {
            coinCounter++;
            Debug.Log("ritch");
            Destroy(other.gameObject);
            CoinCheck();
        }

    
    }
    public void CoinCheck()
    {
        if (coinCounter == 5)
        {
        manager.OpenWinPanel();
        }
    }
}
