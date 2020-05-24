using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

/**
 * @author Stefan Manthey
 * Heavily inspired from
 * Source: https://library.vuforia.com/content/vuforia-library/en/articles/Solution/Working-with-the-Camera.html
 * Script let user switch the camera focus mode
 */
public class CameraFocus : MonoBehaviour
{
    private CameraDevice.FocusMode _mode;
    void Start()
    {
        VuforiaARController vuforia = VuforiaARController.Instance;
        vuforia.RegisterVuforiaStartedCallback(OnVuforiaStarted);
        vuforia.RegisterOnPauseCallback(OnPaused);

        _mode = CameraDevice.FocusMode.FOCUS_MODE_NORMAL;
    }

    private void OnVuforiaStarted()
    {
        CameraDevice.Instance.SetFocusMode(_mode);
    }

    private void OnPaused(bool paused)
    {
        if (!paused) // resumed
        {
            // Set again autofocus mode when app is resumed
            CameraDevice.Instance.SetFocusMode(_mode);
        }
    }

    public void SetModeToNormal()
    {
        _mode = CameraDevice.FocusMode.FOCUS_MODE_NORMAL;
    }

    public void SetModeToContinuousAuto()
    {
        _mode = CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO;
    }

    public void SetModeToMacro()
    {
        _mode = CameraDevice.FocusMode.FOCUS_MODE_MACRO;
    }

    public void SetModeToInfinity()
    {
        _mode = CameraDevice.FocusMode.FOCUS_MODE_INFINITY;
    }
}
