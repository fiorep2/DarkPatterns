using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YvanIdle : StateMachineBehaviour
{
    public float timer;
	public float minTime;
	public float maxTime;
	public float speed;
	private float rand;

	
	Transform transform;
	Transform player;
	private Rigidbody2D rb;
	
	//Boss_flip boss;
	
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
	
	    rand = Random.Range(0, 2);

		//declare the rigid body
		rb = animator.GetComponent<Rigidbody2D>();
	
     timer = Random.Range(minTime, maxTime);
	// boss = animator.GetComponent<Boss_flip>();
	 player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	 transform = animator.GetComponent<Transform>();

    }

   
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
	
		  	transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);


       if (timer <= 0 && rand == 0)
	   {
	   	animator.SetTrigger("Attack");
	   }
	   if (timer <= 0 && rand == 1)
	   {
	   	animator.SetTrigger("Shoot");
	   }
	   else
	   {
	   	timer -= Time.deltaTime;
	   }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
    }
}
