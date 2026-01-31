using UnityEngine;

public class obtainmask : MonoBehaviour
{
    public GameObject botonMascara;
    public GameObject botonSalirHabitacion;

    public void OnClick()
    {
        botonMascara.SetActive(true);
        botonSalirHabitacion.SetActive(true);

        Destroy(transform.parent.gameObject);
    }
}
