using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene2exit : MonoBehaviour
{
   
   public loadlevelscreen1 loadlevelscreen1;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {FindObjectOfType<AudioManager>().Play("LevelCompleted");
           loadlevelscreen1.Setup(1);
           
        }
        
    }
}
