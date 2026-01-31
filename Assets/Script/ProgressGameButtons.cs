using UnityEngine;

public class ProgressGameButtons : MonoBehaviour
{
    public GameObject daughterRoom;

    private bool madeLunch = false;
    private bool grabbedHomework = false;


    void Start()
    {
        daughterRoom.SetActive(false);

        var bags = FindObjectsOfType<Bag>();
        var backpacks = FindObjectsOfType<Backpack>();

        foreach (var bag in bags)
        {
            bag.MadeLunch += MadeLunchObj;
        }

        foreach (var backpack in backpacks)
        {
            backpack.GrabbedHomework += GrabbedHomeworkObj;
        }
    }

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
