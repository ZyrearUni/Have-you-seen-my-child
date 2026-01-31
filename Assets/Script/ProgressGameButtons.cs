using UnityEngine;

public class ProgressGameButtons : MonoBehaviour
{
    public GameObject daughterRoom;

    private bool madeLunch = false;
    private bool grabbedHomework = false;

    public void MadeLunchObj()
    {
        madeLunch = true;
        if(grabbedHomework)
        {
            daughterRoom.SetActive(true);
        }
    }

    public void GrabbedHomeworkObj()
    {
        grabbedHomework = true;
        if (madeLunch)
        {
            daughterRoom.SetActive(true);
        }
    }
}
