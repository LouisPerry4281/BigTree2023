using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float objectiveProgress;
    [SerializeField] float maxObjectives;

    [SerializeField] GameObject levelCompleteObject;
    GameObject player;

    private void Start()
    {
        player = GameObject.Find("PlayerBody");
    }

    public void IncreasePlugs()
    {
        objectiveProgress++;

        if (objectiveProgress >= maxObjectives)
            LevelComplete();
    }

    private void LevelComplete()
    {
        if (levelCompleteObject != null)
        {
            levelCompleteObject.SetActive(true);
            player.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}
