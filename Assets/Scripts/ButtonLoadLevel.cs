using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonLoadLevel : MonoBehaviour {

    public int CurrentLevel = 0;
    public static int maxlevel = 100;
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        if (CurrentLevel < maxlevel)
            {
                SceneManager.LoadScene(CurrentLevel++);
            }
    }
}

    
