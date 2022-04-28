using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pop_walk : StateMachineBehaviour
{
    
	public float timer;
	public float minTime;
	public float maxTime;
	
	public float speed = 0.5f;
	public float attackRange = 5f;
	private Rigidbody2D rb;
	private int rand;
	
	Transform player;
	Transform transform;
	
	//Boss_flip boss;
	
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
     
	 		//declare the rigid body
		rb = animator.GetComponent<Rigidbody2D>();
		//find what the hell we're chasing after
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	 	//boss = animator.GetComponent<Boss_flip>();
		transform = animator.GetComponent<Transform>();
		timer = Random.Range(minTime, maxTime);
    }

 
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<Boss_flip>().LookAtPlayer();
	  	
		//move towards player
		//Vector2 target = new Vector2(player.position.x, rb.position.x );
		//Vector2 newPos = Vector2.MoveTowards(rb.position, target,  speed * Time.deltaTime);
		//rb.MovePosition(newPos);
		
	  	transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
		
		if(Mathf.Abs(player.position.y - rb.position.y) <= attackRange)
		//if (Vector2.Distance(player.position.y, rb.position.y) <= attackRange)
		{ 
		animator.SetTrigger("Attack");
		}
		
		if (timer <= 0)
	   {
	   	animator.SetBool("Move", false);
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