using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour
{
    public GameObject target;
	public float timer = 2;

    public float speed = 10f;

    public Vector3 movePosition;
	private Rigidbody2D rb;
	Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		rb = GetComponent<Rigidbody2D>();
		
    }

    // Update is called once per frame
    void Update()
    {

		Vector2 target = new Vector2(player.position.x, rb.position.x );
		Vector2 newPos = Vector2.MoveTowards(rb.position, target,  speed * Time.deltaTime);
		rb.MovePosition(newPos);

        if (timer <= 0)
        {
            Destroy(gameObject);
			timer = 2;
        }
    }
	
	}

   