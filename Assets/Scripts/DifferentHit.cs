using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifferentHit : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(col.gameObject);

            GameObject deathsManagerObject = GameObject.FindGameObjectWithTag("deaths");
            Deaths deaths = deathsManagerObject.GetComponent<Deaths>();

            deaths.Increase();
        }
    }
}
