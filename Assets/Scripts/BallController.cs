using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Eigener Code
public class BallController : MonoBehaviour
{
    private Rigidbody _myRigidBody;
    private Transform _ball;
    private Vector3 _origin;
    private AudioSource _audioSource;
    private bool _isShot = false;

    private float force = 1.0F;
    public float gravity = 9.0F;
    public float Force
    {
        get
        {
            return force;
        }
        set
        {
            force = value;
        }
    }

    public Vector3 Position
    {
        get
        {
            return _ball.localPosition;
        }
        set
        {
            _ball.localPosition = value;
        }
    }

    public Quaternion Rotation
    {
        get
        {
            return _ball.rotation;
        }
        set
        {
            _ball.rotation = value;
        }
    }

    private void Start()
    {
        _ball = GetComponent<Transform>();
        _myRigidBody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
        _origin = _ball.localPosition;
        Physics.gravity = new Vector3(0.0F, -gravity, 0.0F);
    }

    private void ResetPosition()
    {
        _ball.localPosition = _origin;
        _myRigidBody.velocity = Vector3.zero;
        _myRigidBody.angularVelocity = Vector3.zero;
    }

    public void LaunchBall()
    {
        if (!_isShot)
        {
            _isShot = true;
            _myRigidBody.useGravity = true;
            _myRigidBody.AddForce(_ball.forward * force, ForceMode.Impulse);
            _audioSource.Play();
        }
    }
    
    public bool IsLaunched()
    {
        return _isShot;
    }

    public void ResetBall()
    {
        _isShot = false;
        _myRigidBody.useGravity = false;
        ResetPosition();
    }
}
