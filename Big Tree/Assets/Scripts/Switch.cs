using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] private GameObject switchTarget;

    public bool isFlipped;

    public void FlipSwitch()
    {
        if (isFlipped)
            return;

        switchTarget.GetComponent<Animator>().SetTrigger("goDown");
    }
}
