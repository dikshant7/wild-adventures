using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spikes : MonoBehaviour
{
  Rigidbody2D rb;
	public gameoverscreen1 gameoverscreen1;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.name.Equals ("Player"))
			{
				rb.isKinematic = false;
			 FindObjectOfType<AudioManager>().Play("SpikeSound");
			}
	}
    void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name.Equals("Player"))
        {
			 FindObjectOfType<AudioManager>().Play("GameOver");
             gameoverscreen1.Setup(1);
			 
        }
		else
		{
			Destroy (gameObject, 0.2f);
        }
    }
	// void OnCollisionEnter2D (Collision2D col)
	// {
	// 	if(col.gameObject.name.Equals("Player"))
    //     {
    //         SceneManager.LoadScene(Respawn);
    //     }
	// 	else
	// 	{
	// 		Destroy (gameObject, 0.2f);
	// 	}
	// }
}
