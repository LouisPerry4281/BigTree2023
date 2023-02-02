using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] float pickupDistance = Mathf.Infinity;

    [SerializeField] Transform holdTransform;
    [SerializeField] LayerMask layerMask;

    RaycastHit currentObj;

    Transform mainCamera;

    bool itemIsMovable = false;
    bool holdingObject = false;

    private void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    private void Update()
    {
        itemIsMovable = Physics.Raycast(mainCamera.position, mainCamera.TransformDirection(Vector3.forward), out currentObj, pickupDistance, layerMask);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (itemIsMovable && !holdingObject)
            {
                Pickup();
                itemIsMovable = false;
            }

            else
            {
                Drop();
            }
        }
    }

    void Pickup()
    {
        holdingObject = true;
        currentObj.transform.parent = holdTransform;
        currentObj.transform.rotation = holdTransform.rotation;
        currentObj.transform.localPosition = Vector3.zero;
    }

    void Drop()
    {
        //holdingObject = false;
        currentObj.transform.parent = null;
    }
}
