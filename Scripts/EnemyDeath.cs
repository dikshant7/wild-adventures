using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
   public gameoverscreen1 gameoverscreen1;
   
   void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name.Equals("Player"))
        {
            Destroy(gameObject,0f);
             FindObjectOfType<AudioManager>().Play("GameOver");
             gameoverscreen1.Setup(1);
        }
    }
}
