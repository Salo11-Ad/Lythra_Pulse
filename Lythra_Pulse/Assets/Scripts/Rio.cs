using UnityEngine;

public class Rio : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.Morir();
            GameManager.Instance.ReiniciarNivel();
        }
    }
}
