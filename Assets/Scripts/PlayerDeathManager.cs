using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject Player;
    public GameObject DeathAnim;
    public float DeathAnimCountdown;
    public bool Dead;
    public GameObject DeathScreen;
    public void Die(){
        //Debug.Log("Boink");
        Instantiate(DeathAnim, Player.transform.position, Player.transform.rotation);
        Dead = true;
        Destroy(Player);
    }
    void Start(){

    }
    void Update()
    {
        if(Dead){
            if(DeathAnimCountdown>0){
                DeathAnimCountdown -= Time.deltaTime;
            }else{
                DeathScreen.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void ReloadFunction(){       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
