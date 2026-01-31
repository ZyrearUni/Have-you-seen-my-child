using UnityEngine;

public class MenuDePausa : MonoBehaviour
{
    public GameObject PanelDePausa;
    public GameObject BottonPausa;
    public void PausarJuego()
    {
        Time.timeScale = 0f; // Detener el tiempo del juego
        PanelDePausa.SetActive(true); // Activar el menú de pausa :Dç
        BottonPausa.SetActive(false); // Desactivar el botón de pausa
    }
    public void ReanudarJuego()
    {
        Time.timeScale = 1f; // Reanudar el tiempo del juego
        PanelDePausa.SetActive(false); // Desactivar el menú de pausa :D
        BottonPausa.SetActive(true); // Activar el botón de pausa
    }
}
