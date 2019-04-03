using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPast : MonoBehaviour
{
    public PlayerRotation playerrotation;
    public GameObject bullet;
    public float bulletSpeed;
    Vector2 direction;
    
  
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.Translate(bulletSpeed * direction * Time.deltaTime);



    }

}
