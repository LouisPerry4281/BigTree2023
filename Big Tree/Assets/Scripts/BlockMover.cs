using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMover : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] Transform pos2;

    bool isMoving = false;

    private void Update()
    {
        if (isMoving)
        {
            print("Move");
            transform.position = Vector3.MoveTowards(transform.position, pos2.position, 0.1f * Time.deltaTime);
        }    
    }

    public void MoveMe()
    {
        print("Move Activated");
        isMoving = true;
    }
}
