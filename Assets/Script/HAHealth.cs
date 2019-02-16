using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HAHealth : HHealth {
    public Animator anim;
    public override void Die()
    {
        anim.SetBool("isVisible", false);
        Destroy(this.gameObject);
        Debug.Log("Player ölü");
    }

}
