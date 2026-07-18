using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GestorAccesibilidadVisual : MonoBehaviour
{
    [Header("Textos que serán modificados")]
    [SerializeField] private TMP_Text[] textosAccesibles;

    [Header("Botones y contenedores que aumentarán de tamaño")]
    [SerializeField] private RectTransform[] elementosEscalables;
    private Vector2[] tamanosOriginalesElementos;

    [Header("Fondos que se volverán oscuros")]
    [SerializeField] private Image[] fondosPrincipales;

    [Header("Botones o elementos de acento")]
    [SerializeField] private Image[] elementosDeAcento;

    [Header("Configuración de texto grande")]
    [SerializeField, Range(1.1f, 2f)]
    private float factorTextoGrande = 1.4f;

    [Header("Paleta de alto contraste")]
    [SerializeField] private Color colorTextoContraste = Color.white;
    [SerializeField] private Color colorFondoContraste = Color.black;
    [SerializeField] private Color colorAcentoContraste = Color.yellow;

    private bool textoGrandeActivo;
    private bool altoContrasteActivo;

    private float[] tamanosOriginales;
    private Color[] coloresOriginalesTextos;
    private Color[] coloresOriginalesFondos;
    private Color[] coloresOriginalesAcentos;

    private void Awake()
    {
        GuardarConfiguracionOriginal();

        textoGrandeActivo =
            PlayerPrefs.GetInt("TextoGrandeActivo", 0) == 1;

        altoContrasteActivo =
            PlayerPrefs.GetInt("AltoContrasteActivo", 0) == 1;

        AplicarEstadoAccesibilidad();
    }

    private void GuardarConfiguracionOriginal()
    {
        tamanosOriginales = new float[textosAccesibles.Length];
        coloresOriginalesTextos = new Color[textosAccesibles.Length];

        for (int i = 0; i < textosAccesibles.Length; i++)
        {
            if (textosAccesibles[i] == null)
                continue;

            tamanosOriginales[i] = textosAccesibles[i].fontSize;
            coloresOriginalesTextos[i] = textosAccesibles[i].color;
        }

        coloresOriginalesFondos = new Color[fondosPrincipales.Length];

        for (int i = 0; i < fondosPrincipales.Length; i++)
        {
            if (fondosPrincipales[i] != null)
                coloresOriginalesFondos[i] = fondosPrincipales[i].color;
        }

        coloresOriginalesAcentos = new Color[elementosDeAcento.Length];

        for (int i = 0; i < elementosDeAcento.Length; i++)
        {
            if (elementosDeAcento[i] != null)
                coloresOriginalesAcentos[i] = elementosDeAcento[i].color;
        }

        tamanosOriginalesElementos =
            new Vector2[elementosEscalables.Length];

        for (int i = 0; i < elementosEscalables.Length; i++)
        {
            if (elementosEscalables[i] != null)
            {
                tamanosOriginalesElementos[i] =
                    elementosEscalables[i].rect.size;
            }
        }
    }

    public void ToggleTextoGrande()
    {
        textoGrandeActivo = !textoGrandeActivo;

        PlayerPrefs.SetInt("TextoGrandeActivo", textoGrandeActivo ? 1 : 0);
        PlayerPrefs.Save();

        AplicarEstadoAccesibilidad();

        Debug.Log(
            textoGrandeActivo
                ? "[Accesibilidad] Texto grande ACTIVADO"
                : "[Accesibilidad] Texto grande DESACTIVADO"
        );
    }

    public void ToggleAltoContraste()
    {
        altoContrasteActivo = !altoContrasteActivo;

        PlayerPrefs.SetInt("AltoContrasteActivo", altoContrasteActivo ? 1 : 0);
        PlayerPrefs.Save();

        AplicarEstadoAccesibilidad();

        Debug.Log(
            altoContrasteActivo
                ? "[Accesibilidad] Alto contraste ACTIVADO"
                : "[Accesibilidad] Alto contraste DESACTIVADO"
        );
    }

    private void AplicarEstadoAccesibilidad()
    {
        AplicarTextos();
        AplicarFondos();
        AplicarAcentos();
        AplicarTamanoElementos();
    }

    private void AplicarTextos()
    {
        for (int i = 0; i < textosAccesibles.Length; i++)
        {
            TMP_Text texto = textosAccesibles[i];

            if (texto == null)
                continue;

            texto.fontSize = textoGrandeActivo
                ? tamanosOriginales[i] * factorTextoGrande
                : tamanosOriginales[i];

            texto.color = altoContrasteActivo
                ? colorTextoContraste
                : coloresOriginalesTextos[i];
        }
    }

    private void AplicarFondos()
    {
        for (int i = 0; i < fondosPrincipales.Length; i++)
        {
            Image fondo = fondosPrincipales[i];

            if (fondo == null)
                continue;

            fondo.color = altoContrasteActivo
                ? colorFondoContraste
                : coloresOriginalesFondos[i];
        }
    }

    private void AplicarAcentos()
    {
        for (int i = 0; i < elementosDeAcento.Length; i++)
        {
            Image elemento = elementosDeAcento[i];

            if (elemento == null)
                continue;

            elemento.color = altoContrasteActivo
                ? colorAcentoContraste
                : coloresOriginalesAcentos[i];
        }
    }

    private void AplicarTamanoElementos()
{
        for (int i = 0; i < elementosEscalables.Length; i++)
        {
            RectTransform elemento = elementosEscalables[i];

            if (elemento == null)
                continue;

            float factor = textoGrandeActivo
                ? factorTextoGrande
                : 1f;

            Vector2 nuevoTamano =
                tamanosOriginalesElementos[i] * factor;

            elemento.SetSizeWithCurrentAnchors(
                RectTransform.Axis.Horizontal,
                nuevoTamano.x
            );

            elemento.SetSizeWithCurrentAnchors(
                RectTransform.Axis.Vertical,
                nuevoTamano.y
            );
        }
}
}