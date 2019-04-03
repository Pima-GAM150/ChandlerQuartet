using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public PlayerRotation playerrotation;
    public GameObject bullet;
    public float bulletSpeed;
    public Quaternion itsRotation;
    public float rotateSpeed = 0f;
    public GameObject playerRotation;
    public Transform player;
    public GameObject bulletPrefab;
    private List<GameObject> projectiles = new List<GameObject>();
    public Collider2D enemyPreFab;

    // Update is called once per frame
    void Update()
    {
        //itsRotation = player.transform.rotation;
        //Debug.Log(itsRotation.z);
        Vector3 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed * Time.deltaTime);

        /*if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            projectiles.Add(bullet);

            


        }

        for (int i = 0; i < projectiles.Count; i++)
        {
            GameObject shootBullet = projectiles[i];
            if (shootBullet != null)
            {
                Vector2 bulletScreenPos = (shootBullet.transform.position);
            }
            else
            {
                return;
            }
              bullet.transform.Translate(direction * bulletSpeed * Time.deltaTime);
           // itsRotation = player.transform.rotation;*/
            


        }
    }


