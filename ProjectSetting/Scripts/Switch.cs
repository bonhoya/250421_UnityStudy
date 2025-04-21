using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] GameObject door;

    private bool IsDoorOpend => door.activeSelf == false;

    public void DoorContorl()
    {
        if (IsDoorOpend)
        {
            Close();
        }
        else
            Open();
    }

    public void Close()
    {
        door.SetActive(true);
    }

    public void Open()
    {
        door.SetActive(false);
    }
}
