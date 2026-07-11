using TMPro;
using UnityEngine;

public class ExpoPanelController : MonoBehaviour
{
    [Header("Panel de información")]
    [SerializeField] private GameObject panelExpoInfo;
    [SerializeField] private TMP_Text titulo;
    [SerializeField] private TMP_Text descripcion;

    public void MostrarQueAprenderas()
    {
        MostrarPanel(
            "¿Qué aprenderás?",
            "Aprenderás a reconocer componentes internos de una computadora, conocer su función y comprender cómo se relacionan dentro del sistema."
        );
    }

    public void MostrarComoUsar()
    {
        MostrarPanel(
            "¿Cómo usar la aplicación?",
            "Inicia la experiencia, permite el acceso a la cámara y apunta el dispositivo hacia una imagen registrada. Luego selecciona el botón del componente para consultar su información."
        );
    }

    public void MostrarComponentes()
    {
        MostrarPanel(
            "Componentes disponibles",
            "La aplicación reconoce placa madre, procesador CPU, memoria RAM, tarjeta gráfica GPU y disco duro HDD mediante Image Targets configurados en Vuforia."
        );
    }

    public void CerrarPanel()
    {
        panelExpoInfo.SetActive(false);
    }

    private void MostrarPanel(string nuevoTitulo, string nuevaDescripcion)
    {
        panelExpoInfo.SetActive(true);
        titulo.text = nuevoTitulo;
        descripcion.text = nuevaDescripcion;
    }
}