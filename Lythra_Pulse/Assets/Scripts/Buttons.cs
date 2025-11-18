using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject CreditsPanel;
    public GameObject PausePanel;
    public GameObject SettingsPanel;
    public GameObject PanelInstrucciones;   // ← AGREGADO

    public bool isPaused = false;

    public void PlayGame() 
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void CreditsOn()
    {
        CreditsPanel.SetActive(true);
    }

    public void CreditsOff()
    {
        CreditsPanel.SetActive(false);
    }

    public void PauseOn()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void PauseOff()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void SettingsOn()
    {
        SettingsPanel.SetActive(true);
    }

    public void SettingsOff()
    {
        SettingsPanel.SetActive(false);
    }

    // ---- INSTRUCCIONES ----
    public void InstruccionesOn()
    {
        PanelInstrucciones.SetActive(true);
    }

    public void InstruccionesOff()
    {
        PanelInstrucciones.SetActive(false);
    }
    // ------------------------

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}