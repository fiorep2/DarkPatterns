using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavyFollow : MonoBehaviour
{
	public float speed;
	public float stopDist;
	
	private Rigidbody2D rb;

	private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

		
    }

    // Update is called once per frame
    void Update()
    {
	
	  transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
	 
	 // stop moving when it gets close
	if(Vector2.Distance(transform.position, player.position) < stopDist){
	 speed = 0;
	 }
	 else
	 {
	 speed = 2;
	 }
	 
}
}