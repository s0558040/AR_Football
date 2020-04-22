using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Eigener Code
public class GoalLogic : MonoBehaviour
{
    private bool _isGoal = false;

    public GoalCounter goalCounter;
    public SceneReseter sceneReseter;
    public AudioSource goalSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball" && !_isGoal)
        {
            _isGoal = true;
            goalCounter.ShotGoal();
            goalSound.Play();
            Invoke("Reset", 2.5F);
        }
    }

    void Reset()
    {
        _isGoal = false;
        sceneReseter.ResetScene();
    }
}
