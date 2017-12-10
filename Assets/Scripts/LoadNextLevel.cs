using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class  LoadNextLevel : MonoBehaviour
{
    public Deaths deaths;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player(Clone)")
        {
           SceneManager.LoadScene("Level2");

        }
    }
}