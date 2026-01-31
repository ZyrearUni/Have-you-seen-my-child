using UnityEngine;

public class obtainmask : MonoBehaviour
{
    public GameObject esteBoton;
    public GameObject botonMascara;
    public GameObject botonSalirHabitacion;

    public void OnClick()
    {
        esteBoton.SetActive(false);

        botonMascara.SetActive(true);
        botonSalirHabitacion.SetActive(true);
        
    }
}
