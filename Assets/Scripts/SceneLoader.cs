using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void CargarEscenaAR()
    {
        SceneManager.LoadScene("ARScene");
    }

    public void CargarMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void SalirApp()
    {
        Application.Quit();
    }
}
