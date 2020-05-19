using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

/**
 * Foreign Code
 * Source: https://library.vuforia.com/content/vuforia-library/en/articles/Solution/Working-with-the-Camera.html
 * Script to set camera focus mode to continuous auto
 */
public class CameraFocus : MonoBehaviour
{
    void Start()
    {
        VuforiaARController vuforia = VuforiaARController.Instance;
        vuforia.RegisterVuforiaStartedCallback(OnVuforiaStarted);
        vuforia.RegisterOnPauseCallback(OnPaused);
    }

    private void OnVuforiaStarted()
    {
        CameraDevice.Instance.SetFocusMode(
            CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    private void OnPaused(bool paused)
    {
        if (!paused) // resumed
        {
            // Set again autofocus mode when app is resumed
            CameraDevice.Instance.SetFocusMode(
                CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }
}
