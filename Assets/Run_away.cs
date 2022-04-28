using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Run_away : StateMachineBehaviour
{
   
   Transform player;
   public float runRange;
   public float distance;
   private Rigidbody2D rb;

   
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	rb = animator.GetComponent<Rigidbody2D>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {	
		distance = Mathf.Abs(player.position.y - rb.position.y);

	
        if(distance <= runRange)
		{
		animator.SetTrigger("run");	
		}
		
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
   {
   }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
