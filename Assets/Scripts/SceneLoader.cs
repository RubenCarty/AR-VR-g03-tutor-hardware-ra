using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void CargarMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void CargarExpo()
    {
        SceneManager.LoadScene("ExpoScene");
    }

    public void CargarEscenaAR()
    {
        SceneManager.LoadScene("ARScene");
    }

    public void CargarEvaluacion()
    {
    SceneManager.LoadScene("EvaluationScene");
    }

    public void SalirApp()
    {
        Application.Quit();
    }

    public void FinalizarExperiencia()
    {
        SceneManager.LoadScene("ThanksScene");
    }
}