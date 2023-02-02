using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] private GameObject[] switchTarget;

    public bool isFlipped;

    private void Update()
    {
        if (isFlipped)
        {
            FlipSwitch();
        }
    }

    public void FlipSwitch()
    {
        foreach (GameObject target in switchTarget)
        {
            target.GetComponent<Animator>().SetTrigger("goDown");
        }

        isFlipped = !isFlipped;
    }
}
