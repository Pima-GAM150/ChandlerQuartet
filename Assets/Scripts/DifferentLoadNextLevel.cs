using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DifferentLoadNextLevel : MonoBehaviour {

    
    public int CurrentLevel = 0;
    public static int maxlevel = 100;

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "Player")
        {
            if (CurrentLevel < maxlevel)
            {
                SceneManager.LoadScene(CurrentLevel++);
            }


        }
    }
}