using UnityEngine;

public class TankController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 50f;
    public Transform turret;
    public float turretTurnSpeed = 30f;

    void Update()
    {
        HandleMovement();
        HandleTurretRotation();
    }

    void HandleMovement()
    {
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal"); 
        Vector3 moveDirection = transform.forward * moveInput * moveSpeed * Time.deltaTime;
        transform.Translate(moveDirection, Space.World);
        float turnAmount = turnInput * turnSpeed * Time.deltaTime;
        transform.Rotate(0, turnAmount, 0);
    }
    void HandleTurretRotation()
    {
        if (turret != null)
        {
            float mouseX = Input.GetAxis("Mouse X");
            turret.Rotate(0, mouseX * turretTurnSpeed * Time.deltaTime, 0);
        }
    }

}