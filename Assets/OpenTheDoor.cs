using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{
    public void OpenDoor()
    {
        transform.Rotate(0, -110, 0);
    }
}
