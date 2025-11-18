using UnityEngine;

public class GemaDorada : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.Instance.PuedeTomarGemaDorada())
            {
                GameManager.Instance.GanarNivel();
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Debes recolectar todos los cuarzos primero.");
            }
        }
    }
}
