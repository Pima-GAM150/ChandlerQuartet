using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Hit : Deaths
{


    void OnCollisionEnter2D(Collision2D col)
    { 
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);

		

		
        }
    }
}
