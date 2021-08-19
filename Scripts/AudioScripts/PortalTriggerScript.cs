using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTriggerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("Portal");
        FindObjectOfType<AudioManager>().Play("TransitionFX");
    }

}
