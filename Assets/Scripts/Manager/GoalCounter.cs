using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * @author Stefan Manthey
 * Script to count the goals that were shot
 */
public class GoalCounter : MonoBehaviour
{
    public Text scoreText;      // text of a label that displays the current score
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = string.Format("{0} Tore", score);
    }

    /**
     * <summary>The score will be iteratively increase</summary>
     */
    public void ShotGoal()
    {
        scoreText.text = string.Format("{0} Tore", ++score);
    }
}
