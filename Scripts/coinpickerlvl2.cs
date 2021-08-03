using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinpickerlvl2 : MonoBehaviour
{
     private float coin=0;
    public TextMeshProUGUI textcoins;
    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "coin")
        {Destroy(other.gameObject);
            coin ++;
            textcoins.text=coin.ToString();
            
            
        }
        if(other.transform.tag == "chest")
        {Destroy(other.gameObject);
           coin=coin+10;
            textcoins.text=coin.ToString();
            
            
        }
        
    }
}
