using UnityEngine;

public class HShootState : StateMachineBehaviour {
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<HTankAI>().InvokeRepeating("ShootState", 0f, 0.5f);
    }
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<HTankAI>().Turn();
    }
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<HTankAI>().CancelInvoke("ShootState");
    }
}
