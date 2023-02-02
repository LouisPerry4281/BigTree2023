using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootRenderer : MonoBehaviour
{
    [SerializeField] Transform[] points;
    LineRenderer lineRenderer;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();

        lineRenderer.positionCount = points.Length;
    }

    private void Update()
    {
        print(points[1].position);

        for (int i = 0; i < points.Length; i++)
        {
            //print(points[i].position);
            lineRenderer.SetPosition(i, points[i].position);
        }
    }
}
