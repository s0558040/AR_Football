using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Eigener Code
public class ArrowController : MonoBehaviour
{
    private Transform _arrow;
    private Renderer _arrowRenderer;
    private float _verticalRotation = 0.0F;
    private float _horizontalRotation = 0.0F;

    public Transform ballPostion;
    public BallController ballController;
    public float rotationSpeed = 5.0F;
    public float minVerticalRotation = -80.0F;
    public float maxVerticalRotation = 0.0F;

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

    public void SwitchRenderer()
    {
        _arrowRenderer.enabled = !ballController.IsLaunched();
    }
    public void ResetArrow()
    {
        SwitchRenderer();
        RotateArrow();
    }
    private void RotateArrow()
    {
        _verticalRotation = Mathf.Clamp(_verticalRotation, minVerticalRotation, maxVerticalRotation);
        _arrow.rotation = Quaternion.Euler(_verticalRotation, _horizontalRotation, 0.0F);
        ballPostion.rotation = _arrow.rotation;        
    }
}
