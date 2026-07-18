using TMPro;
using UnityEngine;

public class InfoPanelController : MonoBehaviour
{
    public TMP_Text titulo;
    public TMP_Text descripcion;

    public GameObject panelInfo;

    public void MostrarRAMGeneral()
    {
        panelInfo.SetActive(true);
        titulo.text = "RAM";
        descripcion.text = "Memoria temporal que permite almacenar datos mientras el computador está en funcionamiento.";
    }

    public void MostrarCPUGeneral()
    {
        panelInfo.SetActive(true);
        titulo.text = "Procesador (CPU)";
        descripcion.text = "Procesador principal encargado de ejecutar instrucciones y coordinar las operaciones del sistema.";
    }

    public void MostrarGPUGeneral()
    {
        panelInfo.SetActive(true);
        titulo.text = "Tarjeta de Video (GPU)";
        descripcion.text = "Componente encargado de procesar gráficos, imágenes, video y tareas visuales de alto rendimiento.";
    }

    public void MostrarHDDGeneral()
    {
        panelInfo.SetActive(true);
        titulo.text = "HDD";
        descripcion.text = "Disco duro mecánico utilizado para el almacenamiento permanente de datos. Funciona mediante platos magnéticos giratorios que permiten guardar y recuperar información como documentos, aplicaciones y sistemas operativos.";
    }

    public void MostrarMotherboardGeneral()
    {
        panelInfo.SetActive(true);
        titulo.text = "Placa Madre";
        descripcion.text = "Componente principal que conecta y permite la comunicación entre el procesador, la memoria RAM, la tarjeta gráfica, el almacenamiento y los demás dispositivos del computador.";
    }

    public void OcultarPanel()
    {
        panelInfo.SetActive(false);
    }
}
