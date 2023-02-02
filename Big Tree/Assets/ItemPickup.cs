using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] float pickupDistance = Mathf.Infinity;

    [SerializeField] Transform holdTransform;
    [SerializeField] LayerMask layerMask;

    Transform mainCamera;

    bool itemIsMovable = false;

    private void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    private void Update()
    {
        itemIsMovable = Physics.Raycast(mainCamera.position, mainCamera.TransformDirection(Vector3.forward), pickupDistance, layerMask);
        if (Input.GetKeyDown(KeyCode.Mouse0) && itemIsMovable)
        {
            Pickup();
            itemIsMovable = false;
        }
    }

    void Pickup()
    {
        print("Pick Up");
    }
}
