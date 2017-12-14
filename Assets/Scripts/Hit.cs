using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{
	

    void OnCollisionEnter2D(Collision2D col)
    { 
        if (col.gameObject.name == "Player(Clone)")
        {
            Destroy(col.gameObject);

			GameObject deathsManagerObject = GameObject.FindGameObjectWithTag ("deaths");
			Deaths deaths = deathsManagerObject.GetComponent<Deaths> ();

			deaths.Increase(); 
        }
    }
}
