using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

/**
 * @author Stefan Manthey
 * Script to toogle the smartphone tourch on and off
 */
public class CameraTourch : MonoBehaviour
{
    public Text tourchText;
    private bool _isActive;

    private void Start()
    {
        tourchText.text = "Activate Tourch";
        _isActive = false;
    }

    public void SwitchTourch()
    {
        if(_isActive)
        {
            DeactivateTourch();
        } else
        {
            ActivateTourch();
        }

        _isActive = !_isActive;
    }

    private void ActivateTourch() {
        CameraDevice.Instance.SetFlashTorchMode(true);
        tourchText.text = "Deactivate Tourch";
    }

    private void DeactivateTourch() {
        CameraDevice.Instance.SetFlashTorchMode(false);
        tourchText.text = "Activate Tourch";
    }
}
