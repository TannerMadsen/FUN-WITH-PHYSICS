using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    public bool Flip;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Flip){
            transform.Rotate(0,-Speed,0, Space.Self);
        }else{
            transform.Rotate(0,Speed,0, Space.Self);
        }
        
    }
}
