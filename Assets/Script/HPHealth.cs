using UnityEngine;

public class HPHealth : HHealth
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public override void Die()
    {
        anim.SetBool("isVisible", false);
        Destroy(this.gameObject);
    }
   
}
