using UnityEngine;

public class MoveToButton : MonoBehaviour
{
    public GameObject currentRoom;
    public GameObject destination;

    // Constructor 
    public MoveToButton (GameObject currentRoom, GameObject destination)
    {
        this.currentRoom = currentRoom;
        this.destination = destination;
    }

    // On click interaction, move to destination
    public void OnClick ()
    {
        if (destination != null)
        {
            currentRoom.SetActive(false);
            destination.SetActive(true);
        }
    }
}
