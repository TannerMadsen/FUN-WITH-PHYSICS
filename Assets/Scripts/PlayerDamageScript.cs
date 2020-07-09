using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerDamageScript : MonoBehaviour
{
    public PlayerDeathManager reaper;
    void OnTriggerEnter(Collider other){
        reaper.Die();
    }
    
}
