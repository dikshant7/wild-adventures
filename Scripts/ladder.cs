using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour
{
    public int speed =5;
   void OnTriggerStay2D(Collider2D other)
		{
				if (other.tag == "Player" ) {
						other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, speed);
                }
                else{
                    other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);
                }
        }
}
