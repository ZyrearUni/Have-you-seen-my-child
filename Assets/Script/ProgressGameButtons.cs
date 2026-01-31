using UnityEngine;

public class ProgressGameButtons : MonoBehaviour
{
    public GameObject daughterRoom;
    private bool foundMask = false;
    private bool madeLunch = false;
    private bool grabbedHomework = false;


    public void FoundMask()
    {
        foundMask = true;
    }

    public void MadeLunch()
    {
        madeLunch = true;
        if(grabbedHomework)
        {
            daughterRoom.SetActive(true);
        }
    }

    public void GrabbedHomework()
    {
        grabbedHomework = true;
        if (madeLunch)
        {
            daughterRoom.SetActive(true);
        }
    }
}
