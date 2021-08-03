using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class snakegfx : MonoBehaviour
{
    public AIPath aIPath;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(aIPath.desiredVelocity.x>=0.01f)
        {
            transform.localScale=new Vector3(0.1648618f,0.4051529f,1f);
        }
        else if(aIPath.desiredVelocity.x<=0.01f)
        {
            transform.localScale=new Vector3(-0.1648618f,0.4051529f,1f);
        }
    }
}
