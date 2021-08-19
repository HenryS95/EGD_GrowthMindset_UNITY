using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private Animator OpenDoor;
    [SerializeField] private Animator CloseDoor;

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("doorOpen");

        OpenDoor.SetTrigger("OpenDoor");
    }

    private void OnTriggerExit(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("doorClose");

        CloseDoor.SetTrigger("CloseDoor");
        
    }
}