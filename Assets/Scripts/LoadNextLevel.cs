using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class  LoadNextLevel : MonoBehaviour
{
    public Deaths deaths;
    public int CurrentLevel = 0;
    public static int maxlevel = 100;

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.name == "Player(Clone)")
        {
            if (CurrentLevel < maxlevel)
            {
                SceneManager.LoadScene(CurrentLevel++);
            }
            

        }
    }
}