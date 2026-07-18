using TMPro;
using UnityEngine;

public class ExpoPanelController : MonoBehaviour
{
    [Header("Textos del panel de información")]
    [SerializeField] private TMP_Text titulo;
    [SerializeField] private TMP_Text descripcion;

    private void Start()
    {
        MostrarContenidoInicial();
    }

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
            "Inicia la experiencia, permite el acceso a la cámara y apunta el dispositivo hacia una imagen registrada. Cuando el componente sea reconocido, toca la pantalla para consultar su información."
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
        MostrarContenidoInicial();
    }

    private void MostrarContenidoInicial()
    {
        titulo.text = "Información";
        descripcion.text =
            "Selecciona una opción para conocer más sobre la aplicación.";
    }

    private void MostrarPanel(string nuevoTitulo, string nuevaDescripcion)
    {
        titulo.text = nuevoTitulo;
        descripcion.text = nuevaDescripcion;
    }
}