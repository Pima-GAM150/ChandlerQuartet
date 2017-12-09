using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform enemy;
    public Transform Player;
    public float MoveSpeed = 4;
    public float MaxDist = 10f;
    public float MinDist = 5f;
  
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
  

    void Update()
    {
        {
            
            transform.rotation = Quaternion.LookRotation(Vector3.forward, (Player.position - transform.position).normalized);

            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {

                transform.position += transform.up * MoveSpeed * Time.deltaTime;



                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {
                    //Here Call any function U want Like Shoot at here or something
                }

               
                
            }
        }
    }
}
        
    
