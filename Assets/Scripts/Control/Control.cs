using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int speed = 10, shiftw = 10, shifts = 5;
 
    public GameObject player;//здесь ми указываем персонажа как игровой Object;
   
    void Start()
    {
        player = (GameObject)this.gameObject; //тут присваиваем персонажа к игровому Object или как-то так.
        
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){ player.transform.position += player.transform.forward * speed * Time.deltaTime; }
        if (Input.GetKey(KeyCode.S)){ player.transform.position -= player.transform.forward * speed * Time.deltaTime; }
        if (Input.GetKey(KeyCode.D)){ player.transform.position += player.transform.right * speed * Time.deltaTime; }
        if (Input.GetKey(KeyCode.A)){ player.transform.position -= player.transform.right * speed * Time.deltaTime; }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift)){ player.transform.position += player.transform.forward * (speed + shiftw) * Time.deltaTime; }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift)){ player.transform.position -= player.transform.forward * (speed + shifts) * Time.deltaTime; }
       
    }
    
}