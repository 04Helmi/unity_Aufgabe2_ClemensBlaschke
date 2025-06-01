using UnityEngine;

public class AuaWall : MonoBehaviour
{
    [SerializeField] UIManager manager;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.CompareTag("Obsticale"))
        {

            Die();
        }
    }

    // Update is called once per frame
    public void Die()
    {
        manager.OpenLosePanel();

        Debug.Log("Player died");

        gameObject.SetActive(false);
    }
}
