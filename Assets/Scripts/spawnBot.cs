using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotAI : MonoBehaviour
{
    public Transform player;
    public int distance;
    public Transform enemy;
    public float speedRotation;
    public float speedMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance (transform.position, player.transform.position) < distance)
        {
            Vector3 Rotation = player.position - enemy.position;
            enemy.rotation = Quaternion.Slerp(enemy.rotation, Quaternion.LookRotation(Rotation), speedRotation * Time.deltaTime);

        }
    }
}
