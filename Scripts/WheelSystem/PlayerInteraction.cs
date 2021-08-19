using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerInteraction : MonoBehaviour
{
    private Transform cameraTransform;
    [SerializeField] private float clickDistance;
    [SerializeField] private LayerMask interactableLayers;
 
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = GetComponentInChildren<Camera>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        CheckClick();  
    }

    private void CheckClick()
    {
        //if click
        if (Input.GetMouseButtonDown(0))
        {
            //casts ray/ensures object collider does not interfer with ray 
            Vector3 startPosition = cameraTransform.position - cameraTransform.forward * 1f;
            Debug.DrawRay(startPosition, cameraTransform.forward * clickDistance);

            if (Physics.Raycast(startPosition,cameraTransform.forward,out RaycastHit hitInfo, clickDistance,interactableLayers))
            {
                //Calls button animation on press
                hitInfo.collider.GetComponent<ButtonVP>().OnPress();
                //hitInfo.collider.GetComponent<ButtonP>().OnPress();
            }
        }

    } 
}