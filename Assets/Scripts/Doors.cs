using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    private Animator animator;
    private bool doorOpen;

    void Start() {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        DoorControl("Open");
    }

    //void OnTriggerEnter(Collider c) {
    //    if (c.gameObject.tag == "Chiecken") {
    //        doorOpen = true;
    //        DoorControl("Open");
    //    }
    //}

    //void OnTriggerExit(Collider c)
    //{
    //    if (doorOpen)
    //    {
    //        doorOpen = false;
    //        DoorControl("Close");
    //    }
    //}

    public void DoorControl(string direction)
    {
        animator.SetTrigger(direction);
        animator.SetTrigger("Close");
    }
}
