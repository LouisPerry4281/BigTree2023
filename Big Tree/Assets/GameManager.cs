using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float objectiveProgress;
    [SerializeField] float maxObjectives;

    public void IncreasePlugs()
    {
        objectiveProgress++;

        if (objectiveProgress >= maxObjectives)
            LevelComplete();
    }

    private void LevelComplete()
    {
        print("woo");
    }
}
