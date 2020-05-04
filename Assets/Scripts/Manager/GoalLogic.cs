using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * @author Stefan Manthey
 * Class to register a goal and invokes goal counter after goalcollider (trigger) was hit
 */
public class GoalLogic : MonoBehaviour
{
    private bool _isGoal = false;       // is used to not count a goal twice

    public GoalCounter goalCounter;     // goal counter to iteratively increase the score label
    public SceneReseter sceneReseter;
    public AudioSource goalSound;

    /**
     * <summary>When an gameobject with the tag "Ball" hits the goal collider (trigger),
     * the goal counter will be increased, the goal sound will be played and
     * the scene will be reseted after 2.5 secounds.</summary>
     * <param name="other">object that collided with the trigger</param>
     */
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

    /**
     * <summary>Resets the scene</summary>
     */
    void Reset()
    {
        _isGoal = false;
        sceneReseter.ResetScene();
    }
}
