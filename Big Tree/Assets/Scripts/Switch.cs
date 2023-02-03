using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] private GameObject switchTarget;
    Animator animator1;
    public Animator animator2;

    public bool isFlipped;

    private void Start()
    {
        animator1 = GetComponent<Animator>();
    }

    private void Update()
    {

    }

    public void FlipSwitch()
    {
        switchTarget.GetComponent<Animator>().SetTrigger("goDown");

        animator1.SetTrigger("Switched");
        animator2.SetTrigger("Switched");
    }
}
