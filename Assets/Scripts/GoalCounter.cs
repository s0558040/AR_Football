using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Eigener Code
public class GoalCounter : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = string.Format("{0} Tore", score);
    }

    public void ShotGoal()
    {
        scoreText.text = string.Format("{0} Tore", ++score);
    }
}
