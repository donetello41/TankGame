using System.Collections;
using UnityEngine;

public class HPatrolState : StateMachineBehaviour {

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<HTankAI>().PatrolState();
    }
}
