using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInteract : MonoBehaviour
{
    Transform mainCamera;

    [SerializeField] float pickupDistance = Mathf.Infinity;

    [SerializeField] LayerMask switchLayer;

    private void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;

            if (Physics.Raycast(mainCamera.position, mainCamera.TransformDirection(Vector3.forward), out hit, pickupDistance, switchLayer))
            {
                hit.collider.gameObject.GetComponent<Switch>().FlipSwitch();
            }
        }
    }
}
