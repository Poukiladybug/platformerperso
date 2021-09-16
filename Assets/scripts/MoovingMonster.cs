using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoovingMonster : monster
{
    public Vector2 speed = Vector2.zero;
    private SpriteRenderer spriteRenderer;
    public float hitRange = 0.1f;
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Vector2 start;
        Vector2 direction;

        Vector2 deplacement = speed*Time.deltaTime;
        transform.position += (Vector3)deplacement;

        if (speed.x > 0)
        {
            if (animator != null)
            {
                animator.SetBool("lef", false);
            }
            else
            {
                spriteRenderer.flipX = true;
            }
            start = (Vector2)transform.position + Vector2.right * 0.51f;
            Debug.DrawRay((Vector2)transform.position + Vector2.right * 0.6f, Vector2.right * hitRange, Color.red);
            direction = Vector2.right;

        }
        else
        {
            if (animator != null)
            {
                animator.SetBool("lef", true);
            }
            else
            {
                spriteRenderer.flipX = false;
            }
            start = (Vector2)transform.position + Vector2.left * 0.51f;
            Debug.DrawRay((Vector2)transform.position + Vector2.left * 0.6f, Vector2.left * hitRange, Color.red);
            direction = Vector2.left;
        }


        RaycastHit2D hit = Physics2D.Raycast(start, direction, hitRange);

        if (hit.collider != null && !hit.transform.CompareTag("Player")){
            speed.x *= -1;
        }

        //Debug.DrawRay((Vector2)transform.position + Vector2.right*0.6f, Vector2.right *100, Color.red);
        //RaycastHit2D hit = Physics2D.Raycast((Vector2)transform.position + Vector2.right * 0.6f, Vector2.right);
        //if (hit.collider != null)
        //{
        //    print(hit.collider.name);
        //}
    }
}
