using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class death3 : MonoBehaviour
{
    public gameoverscreen1 gameoverscreen1;
    
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player"))
        {
             FindObjectOfType<AudioManager>().Play("GameOver");
            gameoverscreen1.Setup(1);
        }   
    }
}
