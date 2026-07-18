using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class ARInteractionController : MonoBehaviour
{
    public enum TipoComponente
    {
        Ninguno,
        RAM,
        CPU,
        GPU,
        HDD,
        Motherboard
    }

    [Header("Interfaz")]
    [SerializeField] private GameObject indicadorTocar;
    [SerializeField] private InfoPanelController infoPanelController;

    private TipoComponente componenteReconocido = TipoComponente.Ninguno;
    private bool panelAbierto;

    private void Start()
    {
        panelAbierto = false;

        if (indicadorTocar != null)
            indicadorTocar.SetActive(false);

        if (infoPanelController != null)
            infoPanelController.OcultarPanel();
    }

    private void Update()
    {
        if (componenteReconocido == TipoComponente.Ninguno || panelAbierto)
            return;

        bool huboToque =
            Touchscreen.current != null &&
            Touchscreen.current.primaryTouch.press.wasPressedThisFrame;

        bool huboClic =
            Mouse.current != null &&
            Mouse.current.leftButton.wasPressedThisFrame;

        if (!huboToque && !huboClic)
            return;

        if (PunteroSobreInterfaz())
            return;

        MostrarPanelActual();
    }

    private bool PunteroSobreInterfaz()
{
    if (EventSystem.current == null)
        return false;

    // Comprobación para el mouse en el editor.
    if (Mouse.current != null &&
        Mouse.current.leftButton.wasPressedThisFrame)
    {
        return EventSystem.current.IsPointerOverGameObject();
    }

    // Comprobación para pantalla táctil en Android.
    if (Touchscreen.current != null &&
        Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
    {
        int touchId =
            Touchscreen.current.primaryTouch.touchId.ReadValue();

        return EventSystem.current.IsPointerOverGameObject(touchId);
    }

    return false;
}

    public void ReconocerRAM()
    {
        EstablecerComponente(TipoComponente.RAM);
    }

    public void ReconocerCPU()
    {
        EstablecerComponente(TipoComponente.CPU);
    }

    public void ReconocerGPU()
    {
        EstablecerComponente(TipoComponente.GPU);
    }

    public void ReconocerHDD()
    {
        EstablecerComponente(TipoComponente.HDD);
    }

    public void ReconocerMotherboard()
    {
        EstablecerComponente(TipoComponente.Motherboard);
    }

    private void EstablecerComponente(TipoComponente componente)
    {
        componenteReconocido = componente;
        panelAbierto = false;

        if (infoPanelController != null)
            infoPanelController.OcultarPanel();

        if (indicadorTocar != null)
            indicadorTocar.SetActive(true);
    }

    public void TargetPerdido()
    {
        componenteReconocido = TipoComponente.Ninguno;
        panelAbierto = false;

        if (indicadorTocar != null)
            indicadorTocar.SetActive(false);

        if (infoPanelController != null)
            infoPanelController.OcultarPanel();
    }

    public void MostrarPanelActual()
    {
        if (infoPanelController == null)
            return;

        switch (componenteReconocido)
        {
            case TipoComponente.RAM:
                infoPanelController.MostrarRAMGeneral();
                break;

            case TipoComponente.CPU:
                infoPanelController.MostrarCPUGeneral();
                break;

            case TipoComponente.GPU:
                infoPanelController.MostrarGPUGeneral();
                break;

            case TipoComponente.HDD:
                infoPanelController.MostrarHDDGeneral();
                break;

            case TipoComponente.Motherboard:
                infoPanelController.MostrarMotherboardGeneral();
                break;
                
            default:
                return;
        }

        panelAbierto = true;

        if (indicadorTocar != null)
            indicadorTocar.SetActive(false);
    }

    public void CerrarPanel()
    {
        panelAbierto = false;

        if (infoPanelController != null)
            infoPanelController.OcultarPanel();

        if (componenteReconocido != TipoComponente.Ninguno &&
            indicadorTocar != null)
        {
            indicadorTocar.SetActive(true);
        }
    }
}