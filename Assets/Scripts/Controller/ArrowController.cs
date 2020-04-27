using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @author Stefan Manthey
 * Script to control the arrow gameobject behavior, as well as the angle of the ball (to set the direction the ball will be kicked)
 */
public class ArrowController : MonoBehaviour
{
    private Transform _arrow;                       // transform component of the arrow gameobject
    private Renderer _arrowRenderer;                // renderer of the arrow model
    private float _verticalRotation = 0.0F;
    private float _horizontalRotation = 0.0F;

    public Transform ballPostion;                   // tranform component of the ball gameobject
    public BallController ballController;           // ballController script of the ball
    public float rotationSpeed = 5.0F;              // the speed in with the arrow model rotates
    public float minVerticalRotation = -80.0F;      // max. vertical rotation angle of 80°
    public float maxVerticalRotation = 0.0F;        // min. vertical rotation angle of 0°

    // Start is called before the first frame update
    void Start()
    {
        _arrow = gameObject.GetComponent<Transform>();
        _arrowRenderer = gameObject.GetComponentInChildren<Renderer>();
        _arrow.position = ballPostion.position;
    }

    public void RotateUp()
    {
        _verticalRotation -= rotationSpeed;
        RotateArrow();
    }

    public void RotateDown()
    {
        _verticalRotation += rotationSpeed;
        RotateArrow();
    }

    public void RotateLeft()
    {
        _horizontalRotation -= rotationSpeed;
        RotateArrow();
    }

    public void RotateRight()
    {
        _horizontalRotation += rotationSpeed;
        RotateArrow();
    }

    /**
     * Sets the mesh renderer of the arrow to in-/visible
     * <param name="state">true, the arrow will be rendered</param>
     */
    public void SwitchRenderer(bool state)
    {
        _arrowRenderer.enabled = state;
    }

    /**
     * Resets the Arrow and sets the mesh renderer to visible
     */
    public void ResetArrow()
    {
        SwitchRenderer(!ballController.IsLaunched());
        RotateArrow();
    }

    /**
     * Rotates the arrow gameobject and sets the angle of the ball to the same angle of the arrow
     */
    private void RotateArrow()
    {
        _verticalRotation = Mathf.Clamp(_verticalRotation, minVerticalRotation, maxVerticalRotation);
        _arrow.rotation = Quaternion.Euler(_verticalRotation, _horizontalRotation, 0.0F);
        ballPostion.rotation = _arrow.rotation;        
    }
}
