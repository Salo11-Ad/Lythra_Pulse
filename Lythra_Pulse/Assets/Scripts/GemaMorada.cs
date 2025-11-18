using UnityEngine;

public class GemaMorada : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AgregarGemaMorada();
            Destroy(gameObject);
        }
    }
}
