﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Start() {
        for (int i = 0; i < buttons.Length; i++)
        {
            int score = PlayerPrefs.GetInt(buttons[i].playerPrefKey, 0);

            for (int starIndex = 1; starIndex <= 3; starIndex++) 
            {
                Transform star = buttons[i].gameObject.transform.Find("star" + starIndex);
                if (starIndex <= score) {
                    star.gameObject.SetActive(true);
                } 
                else
                {
                    star.gameObject.SetActive(false);
                }
            }
        }
    }

    public void OnButtonPress(string levelName) {
        SceneManager.LoadScene(levelName);
    }

    [System.Serializable]
    public struct ButtonPlayerPrefs {
        public GameObject gameObject;
        public string playerPrefKey;
    }

    public ButtonPlayerPrefs[] buttons;
}
