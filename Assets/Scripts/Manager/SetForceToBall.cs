using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * @author Stefan Manthey
 * Script to set the force value, to kick the ball
 */
public class SetForceToBall : MonoBehaviour
{
    public BallController ballController;
    public Slider slider;

    private void Start()
    {
        SetForce();
    }

    /**
     * Sets the force to kick the ball from the current slider value
     */
    public void SetForce()
    {
        ballController.Force = slider.value;
    }
}
