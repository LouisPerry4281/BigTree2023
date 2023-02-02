using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFacing : MonoBehaviour
{
    Transform cameraPos;

    private void Start()
    {
        cameraPos = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    private void Update()
    {
        transform.LookAt(new Vector3(cameraPos.position.x, transform.position.y, cameraPos.position.z));
    }
}
