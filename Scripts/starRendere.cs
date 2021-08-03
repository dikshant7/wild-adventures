using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starRendere : MonoBehaviour
{
     
   void start()
   {
       GetComponent<StarHandler>().starsCollected();
   }
}
