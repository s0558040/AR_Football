using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @author Stefan Manthey
 * Script to control the behavior of the ball
 */
public class BallController : MonoBehaviour
{
    private Rigidbody _myRigidBody;         // rigidbody component of the ball gameobject
    private Transform _ball;                // transform component of the ball gameobject
    private Vector3 _origin;                // used to save the origin position of the ball
    private AudioSource _audioSource;       // audio source to play a kick sound when the ball was kicked
    private bool _isShot = false;           // to check if the ball was already kicked

    private float force = 1.0F;             // force value to kick the ball
    public float gravity = 9.0F;            // gravity that is used in the scene
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

    private void Start()
    {
        _ball = GetComponent<Transform>();
        _myRigidBody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
        _origin = _ball.localPosition;
        Physics.gravity = new Vector3(0.0F, -gravity, 0.0F);
    }

    /**
     * <summary>Sets the position of the ball back to the origin position.
     * All velocity force will be set to zero</summary>
     */
    private void ResetPosition()
    {
        _ball.localPosition = _origin;
        _myRigidBody.velocity = Vector3.zero;
        _myRigidBody.angularVelocity = Vector3.zero;
    }

    /**
     * <summary>Kicks the ball with the set force in the current direction.
     * and plays an audio clip.
     * It also activates the gravity</summary>
     */
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

    /**
     * <summary>Checks if the ball was already kicked</summary>
     */
    public bool IsLaunched()
    {
        return _isShot;
    }

    /**
     * <summary>Resets the position of the ball to the origin point and deactivates the gravity</summary>
     */
    public void ResetBall()
    {
        _isShot = false;
        _myRigidBody.useGravity = false;
        ResetPosition();
    }
}
