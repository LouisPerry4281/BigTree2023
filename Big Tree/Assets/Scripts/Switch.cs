using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] private GameObject switchTarget;

    public bool isFlipped;

    private void Update()
    {

    }

    public void FlipSwitch()
    {
        switchTarget.GetComponent<Animator>().SetTrigger("goDown");
        print(isFlipped);

        //isFlipped = !isFlipped;
    }
}
