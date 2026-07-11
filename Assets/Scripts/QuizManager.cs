using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class PreguntaQuiz
{
    public string pregunta;

    [TextArea(2, 4)]
    public string[] alternativas;

    public int respuestaCorrecta;
}

public class QuizManager : MonoBehaviour
{
    [Header("Interfaz")]
    [SerializeField] private TMP_Text textoProgreso;
    [SerializeField] private TMP_Text textoPregunta;
    [SerializeField] private TMP_Text textoRetroalimentacion;
    [SerializeField] private Button[] botonesRespuesta;
    [SerializeField] private Button botonSiguiente;

    [Header("Preguntas")]
    [SerializeField] private List<PreguntaQuiz> preguntas =
        new List<PreguntaQuiz>();

    private int indicePregunta;
    private int puntaje;
    private bool preguntaRespondida;

    private void Start()
    {
        CrearPreguntas();

        indicePregunta = 0;
        puntaje = 0;
        MostrarPregunta();
    }

    private void CrearPreguntas()
    {
        preguntas.Clear();

        preguntas.Add(new PreguntaQuiz
        {
            pregunta = "¿Qué componente ejecuta las instrucciones del sistema?",
            alternativas = new[]
            {
                "CPU",
                "RAM",
                "GPU",
                "HDD"
            },
            respuestaCorrecta = 0
        });

        preguntas.Add(new PreguntaQuiz
        {
            pregunta = "¿Qué componente almacena temporalmente los datos?",
            alternativas = new[]
            {
                "HDD",
                "GPU",
                "RAM",
                "Placa madre"
            },
            respuestaCorrecta = 2
        });

        preguntas.Add(new PreguntaQuiz
        {
            pregunta = "¿Qué componente procesa principalmente los gráficos?",
            alternativas = new[]
            {
                "CPU",
                "GPU",
                "RAM",
                "HDD"
            },
            respuestaCorrecta = 1
        });

        preguntas.Add(new PreguntaQuiz
        {
            pregunta = "¿Qué componente guarda archivos de forma permanente?",
            alternativas = new[]
            {
                "RAM",
                "CPU",
                "HDD",
                "GPU"
            },
            respuestaCorrecta = 2
        });

        preguntas.Add(new PreguntaQuiz
        {
            pregunta = "¿En qué componente se conectan las demás piezas del computador?",
            alternativas = new[]
            {
                "GPU",
                "Placa madre",
                "HDD",
                "RAM"
            },
            respuestaCorrecta = 1
        });
    }

    private void MostrarPregunta()
    {
        if (indicePregunta >= preguntas.Count)
        {
            FinalizarEvaluacion();
            return;
        }

        preguntaRespondida = false;
        botonSiguiente.gameObject.SetActive(false);
        textoRetroalimentacion.text = "Selecciona una respuesta.";

        PreguntaQuiz preguntaActual = preguntas[indicePregunta];

        textoProgreso.text =
            $"Pregunta {indicePregunta + 1} de {preguntas.Count}";

        textoPregunta.text = preguntaActual.pregunta;

        for (int i = 0; i < botonesRespuesta.Length; i++)
        {
            botonesRespuesta[i].interactable = true;

            TMP_Text textoBoton =
                botonesRespuesta[i].GetComponentInChildren<TMP_Text>();

            if (i < preguntaActual.alternativas.Length)
            {
                botonesRespuesta[i].gameObject.SetActive(true);
                textoBoton.text = preguntaActual.alternativas[i];
            }
            else
            {
                botonesRespuesta[i].gameObject.SetActive(false);
            }
        }
    }

    public void Responder(int indiceSeleccionado)
    {
        if (preguntaRespondida)
        {
            return;
        }

        preguntaRespondida = true;

        PreguntaQuiz preguntaActual = preguntas[indicePregunta];
        bool esCorrecta =
            indiceSeleccionado == preguntaActual.respuestaCorrecta;

        if (esCorrecta)
        {
            puntaje++;
            textoRetroalimentacion.text = "¡Respuesta correcta!";
        }
        else
        {
            string respuestaCorrecta =
                preguntaActual.alternativas[
                    preguntaActual.respuestaCorrecta
                ];

            textoRetroalimentacion.text =
                $"Respuesta incorrecta. La respuesta correcta era: {respuestaCorrecta}.";
        }

        foreach (Button boton in botonesRespuesta)
        {
            boton.interactable = false;
        }

        botonSiguiente.gameObject.SetActive(true);
    }

    public void SiguientePregunta()
    {
        if (!preguntaRespondida)
        {
            return;
        }

        indicePregunta++;
        MostrarPregunta();
    }

    private void FinalizarEvaluacion()
    {

        foreach (Button boton in botonesRespuesta)
        {
            boton.gameObject.SetActive(false);
        }

        botonSiguiente.gameObject.SetActive(false);

        PlayerPrefs.SetInt("PuntajeQuiz", puntaje);
        PlayerPrefs.SetInt("TotalPreguntas", preguntas.Count);
        PlayerPrefs.Save();

        StartCoroutine(IrAResultados());
    }

    private IEnumerator IrAResultados()
    {
        textoProgreso.text = "Evaluación completada";
        textoPregunta.text = "Preparando tus resultados...";
        textoRetroalimentacion.text = "Gracias por completar el cuestionario.";

        foreach (Button boton in botonesRespuesta)
        {
            boton.gameObject.SetActive(false);
        }

        botonSiguiente.gameObject.SetActive(false);

        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene("ResultsScene");
    }
}