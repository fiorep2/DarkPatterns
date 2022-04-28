using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndieMarc.TopDown
{
    [RequireComponent(typeof(Enemy))]
    public class PopAmin : MonoBehaviour
    {
        public GameObject death_fx_prefab;
        
        private Animator animator;
        private SpriteRenderer render;
        private Enemy enemy;
        private float flash_fx_timer;

        void Awake()
        {
            animator = GetComponentInChildren<Animator>();
            render = GetComponentInChildren<SpriteRenderer>();
            enemy = GetComponent<Enemy>();

            enemy.onDeath += OnDeath;
            enemy.onHit += OnDamage;
        }
		
		 void OnDamage()
        {
            if (!enemy.IsDead())
                flash_fx_timer = 1f;
				animator.SetTrigger("Hurt");
        }

        private void OnDeath()
        {
            if(death_fx_prefab)
                Instantiate(death_fx_prefab, transform.position, death_fx_prefab.transform.rotation);

            if (animator != null)
                animator.SetTrigger("Death");
        }
    }
}