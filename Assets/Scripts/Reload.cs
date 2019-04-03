using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{

    public int CurrentLevel = 0;
    public static int maxlevel = 100;

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            if (CurrentLevel < maxlevel)
            {
                SceneManager.LoadScene(CurrentLevel++);
            }


        }
    }
}