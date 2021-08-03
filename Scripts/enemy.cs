using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
   
    public float movespeed=3f;
    bool movingRight = true;
    Transform leftwaypoint,rightwaypoint;
    Vector3 localScale;
    public gameoverscreen1 gameoverscreen1;
    Rigidbody2D rb;
    void Start()
    {
        localScale=transform.localScale;
         rb=GetComponent<Rigidbody2D>();
         leftwaypoint=GameObject.Find("LeftWayPoint").GetComponent<Transform> ();
         rightwaypoint=GameObject.Find("RightWayPoint").GetComponent<Transform> ();
    }
    void Update()
    {
       if(transform.position.x > rightwaypoint.position.x)
           movingRight=false;
       if(transform.position.x < leftwaypoint.position.x)
           movingRight=true;
       if(movingRight)
            moveRight();
        else
            moveLeft();
    }
     void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name.Equals("Player"))
        {
             gameoverscreen1.Setup(1);
        }
		
    }
    void moveRight()
    {
        movingRight=true;
        localScale.x=1;
        transform.localScale=localScale;
        rb.velocity=new Vector2(localScale.x*movespeed,rb.velocity.y);
    }
     void moveLeft()
    {
        movingRight=false;
        localScale.x=-1;
        transform.localScale=localScale;
        rb.velocity=new Vector2(localScale.x*movespeed,rb.velocity.y);
    }
}
