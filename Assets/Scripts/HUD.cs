using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Level level;
    public Text remainingText;
    public Text remainingSubtext;
    public Text targetText;
    public Text targetSubtext;
    public Text scoreText;
    public Image[] stars;

    private int starIndex;
    private bool isGameOver;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
