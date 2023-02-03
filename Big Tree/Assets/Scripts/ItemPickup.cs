using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] float pickupDistance = Mathf.Infinity;

    [SerializeField] Transform holdTransform;
    [SerializeField] LayerMask pickupMask;
    [SerializeField] LayerMask plugMask;

    GameObject currentObj;
    GameObject heldObject;

    Transform mainCamera;
    GameManager gameManager;

    bool itemIsMovable = false;
    bool holdingObject = false;

    private void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Transform>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;

            if (!holdingObject && Physics.Raycast(mainCamera.position, mainCamera.TransformDirection(Vector3.forward), out hit, pickupDistance, pickupMask))
            {
                currentObj = hit.collider.gameObject;
                Pickup();
                return;
            }

            if (!holdingObject)
                return;

            heldObject = currentObj;

            if (Physics.Raycast(mainCamera.position, mainCamera.TransformDirection(Vector3.forward), out hit, pickupDistance, plugMask))
            {
                currentObj = hit.collider.gameObject;
                Plug();
                return;
            }

            else
                Drop();
        }
    }

    private void Plug()
    {
        holdingObject = false;
        currentObj.transform.parent = null;

        heldObject.transform.parent = currentObj.transform;
        heldObject.transform.localPosition = Vector3.zero;
        print(heldObject.name + " + " + currentObj.name);

        Rigidbody rb = heldObject.GetComponent<Rigidbody>();
        rb.isKinematic = true;
        rb.useGravity = false;

        heldObject.layer = 0;

        gameManager.IncreasePlugs();
    }

    void Pickup()
    {
        holdingObject = true;
        currentObj.transform.parent = holdTransform;
        currentObj.transform.rotation = holdTransform.rotation;
        currentObj.transform.Rotate(new Vector3(0, 90, 0));
        currentObj.transform.localPosition = Vector3.zero;

        Rigidbody rb = currentObj.GetComponent<Rigidbody>();
        rb.isKinematic = true;
        rb.useGravity = false;
    }

    void Drop()
    {
        holdingObject = false;
        currentObj.transform.parent = null;

        Rigidbody rb = currentObj.GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.useGravity = true;
    }
}
