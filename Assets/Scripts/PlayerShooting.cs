using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public Rigidbody2D bulletPrefab;
    public float attackSpeed = 1.0f;
    public float coolDown;
    public float bulletSpeed = 5;
    public float yValue = 1f; // Used to make it look like it's shot from the gun itself (offset)
    public float xValue = 0.2f; // Same as above


    // Update is called once per frame
    void Update()
    {

        if (Time.time >= coolDown)
        {
            if (Input.GetMouseButton(0))
            {
                Fire();
                
                
            }
        }
        //bulletPrefab.transform.Translate(bulletPrefab.transform.localPosition * 5f * Time.deltaTime);
        //bulletPrefab.transform.Translate(transform.up * bulletSpeed * Time.deltaTime);
    }

    void Fire()
    {
        //Rigidbody2D bPrefab = Instantiate(bulletPrefab,transform.position,Quaternion.identity) as Rigidbody2D;

        Rigidbody2D bPrefab = Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        bulletPrefab.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
        


        coolDown = Time.time + attackSpeed;
    }
    
}
