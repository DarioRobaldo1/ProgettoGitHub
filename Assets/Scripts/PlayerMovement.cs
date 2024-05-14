using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody), typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{
    private Vector2 directionInputs;
    [SerializeField] private float MovementBoost = 1.0f;
    [SerializeField] private float MovementSpeed = 50.0f;
    [SerializeField] private float RotationSpeed = 50.0f;
    private Rigidbody rb;
    private RoundManager rm;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rm = FindObjectOfType<RoundManager>();
    }

    public void OnMovementInputChange(InputAction.CallbackContext cc)
    {
        directionInputs = cc.ReadValue<Vector2>(); // Save the movement inputs values for later
    }
    private void FixedUpdate()
    {
        if (!rm.HasGameStarted) { return; }
        // Calculate and apply movement and rotation
        Vector3 forwardMovement = directionInputs.y * MovementSpeed * transform.forward * MovementBoost;
        rb.AddForce(forwardMovement, ForceMode.Force);
        Vector3 rotationMovement = directionInputs.x * RotationSpeed * transform.up * Mathf.Clamp(MovementBoost / 2.5f, 1.0f, float.PositiveInfinity);
        rb.AddTorque(rotationMovement, ForceMode.Force);
    }
}
