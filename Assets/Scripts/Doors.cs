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

    void OnTriggerEnter(Collider c) {
        if (c.gameObject.tag == "Player") {
            doorOpen = true;
            DoorControl("Open");
        }
    }

    void OnTriggerExit(Collider c) {
        if (doorOpen) {
            doorOpen = false;
            DoorControl("Close");
        }
    }

    void DoorControl(string direction) {
        animator.SetTrigger(direction);
    }
}
