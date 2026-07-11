using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultsManager : MonoBehaviour
{
    [Header("Textos de resultados")]
    [SerializeField] private TMP_Text textoPuntaje;
    [SerializeField] private TMP_Text textoPorcentaje;
    [SerializeField] private TMP_Text textoMensaje;

    private void Start()
    {
        MostrarResultados();
    }

    private void MostrarResultados()
    {
        int puntaje = PlayerPrefs.GetInt("PuntajeQuiz", 0);
        int totalPreguntas = PlayerPrefs.GetInt("TotalPreguntas", 5);

        float porcentaje = totalPreguntas > 0
            ? (float)puntaje / totalPreguntas * 100f
            : 0f;

        textoPuntaje.text =
            $"{puntaje} de {totalPreguntas} respuestas correctas";

        textoPorcentaje.text =
            $"{porcentaje:0}% de aciertos";

        if (porcentaje >= 80f)
        {
            textoMensaje.text =
                "¡Excelente trabajo! Reconoces correctamente los componentes.";
        }
        else if (porcentaje >= 60f)
        {
            textoMensaje.text =
                "Buen resultado. Puedes repasar algunos componentes.";
        }
        else
        {
            textoMensaje.text =
                "Sigue practicando. Te recomendamos volver al modo aprendizaje.";
        }
    }

    public void ReintentarEvaluacion()
    {
        SceneManager.LoadScene("EvaluationScene");
    }

    public void FinalizarExperiencia()
    {
        SceneManager.LoadScene("ThanksScene");
    }
}