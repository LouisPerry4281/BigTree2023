using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] private GameObject switchTarget;

    public bool isFlipped;

    private void Update()
    {
        if (isFlipped)
        {
            switchTarget.GetComponent<Animator>().SetTrigger("goDown");
        }
    }

    public void FlipSwitch()
    {
        //if (isFlipped)
            //return;

        //switchTarget.GetComponent<BlockMover>().MoveMe();
    }
}
