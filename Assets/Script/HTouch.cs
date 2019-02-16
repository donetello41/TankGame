using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HTouch : HSense {
    HAspect aspect;
    Animator anim;
    public override void Initialized()
    {
        anim = GetComponent<Animator>();
    }

    public override void UpdateSense()
    {
        if (aspect != null)
        {
            if (aType == aspect.aType)
            {
                anim.SetBool("isVisible", true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        aspect = other.GetComponent<HAspect>();

    }
    private void OnTriggerExit(Collider other)
    {
        aspect = null;
        anim.SetBool("isVisible", false);
    }

}
