using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YvanShoot : StateMachineBehaviour
{

    [SerializeField]
	GameObject bullet;

	public float fireRate;
	float nextFire;
	
	Transform transform;
	Transform player;
	private Rigidbody2D rb;


    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        nextFire = Time.time;
		transform = animator.GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		rb = animator.GetComponent<Rigidbody2D>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Time.time > nextFire && Mathf.Abs(player.position.y - transform.position.y) <= 0) {
			Instantiate (bullet, rb.position, Quaternion.identity);
			nextFire = Time.time + fireRate;
		}
		
		  if (Time.time > nextFire && Mathf.Abs(player.position.y - transform.position.y) > 0) {
			Instantiate (bullet, rb.position, Quaternion.identity);
			nextFire = Time.time + fireRate;
		}
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

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
