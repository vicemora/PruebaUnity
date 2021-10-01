using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{    
    Animator animator;

    void Start(){
        animator = gameObject.GetComponent<Animator>();
        animator.SetBool("destroyed", false);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("proyectile(Clone)"))
            animator.SetBool("destroyed", true);
    }

    void OnBecameInvisible(){
        Destroy(gameObject);
    }
}
