using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Conteo de gemas")]
    public int moradasRecogidas = 0;
    public int rosasRecogidas = 0;
    public int totalMoradas = 6;
    public int totalRosas = 6;

    [Header("Puntaje")]
    public int puntajeTotal = 0;

    [HideInInspector]
    public bool nivelCompletado = false;
    [HideInInspector]
    public bool jugadorMuerto = false;

    [HideInInspector]
    public bool puedeTomarDorada = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AgregarGemaMorada()
    {
        moradasRecogidas++;
        puntajeTotal += 1;
        RevisarVictoria();
        Debug.Log($"Moradas: {moradasRecogidas}/{totalMoradas} | Puntaje: {puntajeTotal}");
    }

    public void AgregarGemaRosa()
    {
        rosasRecogidas++;
        puntajeTotal += 2;
        RevisarVictoria();
        Debug.Log($"Rosas: {rosasRecogidas}/{totalRosas} | Puntaje: {puntajeTotal}");
    }

    private void RevisarVictoria()
    {
        if (moradasRecogidas >= totalMoradas && rosasRecogidas >= totalRosas)
        {
            puedeTomarDorada = true;
            Debug.Log("Ya puedes tomar la Gema Dorada.");
        }
        else
        {
            puedeTomarDorada = false;
        }
    }

    public bool PuedeTomarGemaDorada()
    {
        return puedeTomarDorada;
    }

    public void GanarNivel()
    {
        if (!nivelCompletado)
        {
            nivelCompletado = true;
            Debug.Log("¡Nivel completado!");
        }
    }

    public void Morir()
    {
        if (!jugadorMuerto)
        {
            jugadorMuerto = true;
            Debug.Log("Has muerto");
        }
    }

    public void ReiniciarNivel()
    {
        nivelCompletado = false;
        jugadorMuerto = false;
        puedeTomarDorada = false;
        moradasRecogidas = 0;
        rosasRecogidas = 0;
        puntajeTotal = 0;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
