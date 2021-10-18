using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    // Start is called before the first frame update
   
    public float movespeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    public Animator animator;
   
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
       animator.SetFloat("Horizontal",movement.x);
       animator.SetFloat("Vertical", movement.y);
       animator.SetFloat("speed", movement.sqrMagnitude);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }
}