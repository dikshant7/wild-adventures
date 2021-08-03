using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class playerscript2 : MonoBehaviour
{public Animator animator;
   Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    bool isGrounded = false; 
    public Transform isGroundedChecker; 
    public float checkGroundRadius; 
    public LayerMask groundLayer;
    public float fallMultiplier = 2.5f; 
    public float lowJumpMultiplier = 2f;
    public float rememberGroundedFor; 
    private bool lastDir;
    private SpriteRenderer sr;
    // public Animator animator;
    
float lastTimeGrounded;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
   
    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        CheckIfGrounded();
        BetterJump();
        UpdateDirection();
    }
    void Move(){
        float x = CrossPlatformInputManager.GetAxis("Horizontal"); //-> x=+1 <- x=-1
        
        float moveBy = x * speed; 
        rb.velocity = new Vector2(moveBy, rb.velocity.y);//vector2
        animator.SetFloat("speed",Mathf.Abs(x));//for run animation
    }
    void Jump(){
        if (CrossPlatformInputManager.GetButtonDown("Jump") && (isGrounded || Time.time - lastTimeGrounded <= rememberGroundedFor)){
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            
            animator.SetBool("isjumping",rb);
            
            
           
        }
    }
    void CheckIfGrounded() { 
    Collider2D colliders = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer); 
   
    if (colliders != null) { 
        isGrounded = true; 
        
    } else { 
        
        if (isGrounded) { 
            lastTimeGrounded = Time.time; 
        } 
        isGrounded = false; 
    } 
     animator.SetBool("isjumping",!isGrounded);
}

    void BetterJump() {
        if (rb.velocity.y < 0) {
         rb.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
    } else if (rb.velocity.y > 0 && !CrossPlatformInputManager.GetButton("Jump")) {
        rb.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
     }   
     }
     private void UpdateDirection()
{
    if (CrossPlatformInputManager.GetAxis("Horizontal") > 0)
    {
        sr.flipX = false;
        lastDir = false;
    }
    else if (CrossPlatformInputManager.GetAxis("Horizontal") < 0)
    {
        sr.flipX = true;
        lastDir = true;
    }
    else sr.flipX = lastDir;
}
}