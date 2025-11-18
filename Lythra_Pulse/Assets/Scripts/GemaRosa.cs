using UnityEngine;

public class GemaRosa : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AgregarGemaRosa();
            Destroy(gameObject);
        }
    }
}
