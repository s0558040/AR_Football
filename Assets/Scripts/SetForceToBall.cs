using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetForceToBall : MonoBehaviour
{
    public BallController ballController;
    public Slider slider;

    private void Start()
    {
        SetForce();
    }

    public void SetForce()
    {
        ballController.Force = slider.value;
    }
}
