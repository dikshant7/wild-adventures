using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpikeDeath : MonoBehaviour
{
    public gameoverscreen1 gameoverscreen1;
    
   void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name.Equals("Player"))
        {
             gameoverscreen1.Setup(1);
        }
		else
		{
			Destroy (gameObject, 0.2f);
        }
    }
}
