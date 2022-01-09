using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth =100;
    public int currHealth;
    public Animator anim;
    public Transform transform;
    void Start()
    {
        currHealth= maxHealth;
    }

 
    public void TakeDamage(int damage){
        // animation for hurt
        if(currHealth <=0){
            Die();
        }
        currHealth -= damage;

        if(currHealth <=0){
            Die();
        }
    }

    void Die(){
        // animation for dying
        anim.SetBool("die",true);
        anim.SetTrigger("die");
        //disable enemy after death
        Destroy(gameObject);
    }
}
