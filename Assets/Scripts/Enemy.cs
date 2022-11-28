using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour,IDamageable
{
    Transform targetDestination;
    GameObject targetGameObject;
    Character targetCharacter;
    [SerializeField] float speed;

    Rigidbody2D rgdb2d;

    [SerializeField] int hp = 99;
    [SerializeField] int damage = 10;
    [SerializeField] int experience_reward=400;


    private void Awake()
    {
        rgdb2d=GetComponent<Rigidbody2D>();
        
    }

    public void SetTarget(GameObject target)
    {
        targetGameObject = target;
        targetDestination = target.transform;
    }


    private void FixedUpdate()
    {
        Vector3 direction = (targetDestination.position - transform.position).normalized;
        rgdb2d.velocity = direction * speed;
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject== targetGameObject)
        {
            Attack();
        }
    }

    private void Attack()
    {
        if (targetCharacter==null)
        {
            targetCharacter=targetGameObject.GetComponent<Character>();
        }

        targetCharacter.TakeDamage(damage);
    }
    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp < 1)
        {
            targetGameObject.GetComponent<Level>().AddExperience(experience_reward);
            Destroy(gameObject);
        }
    }
  }
