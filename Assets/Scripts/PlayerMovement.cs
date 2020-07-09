using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody priggity;
    public float DefaultSpeed;
    public float Speed;
    private Vector3 move;
    public GameObject PauseScreen;
    public GameObject StartScreen;
    public bool paused;
    
    
    // Start is called before the first frame update
    void Start()
    {
        priggity = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(paused){
                Unpause();
            }else{
                Pause();
            }
            
        }
        move = new Vector3 (Input.GetAxis("Horizontal") * Speed, 0, (Input.GetAxis("Vertical") * Speed) + DefaultSpeed);
    }
    void FixedUpdate(){
        priggity.velocity = move;
    }
    public void Pause(){
        Time.timeScale = 0;
        PauseScreen.SetActive(true);
    }
    public void Unpause(){
        Time.timeScale = 1;
        PauseScreen.SetActive(false);
        StartScreen.SetActive(false);
    }
    
}
