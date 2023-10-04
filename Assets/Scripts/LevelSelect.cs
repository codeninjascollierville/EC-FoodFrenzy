using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
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
