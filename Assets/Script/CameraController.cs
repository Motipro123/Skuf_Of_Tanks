using UnityEngine;

public class CameraRotation : GunController
{
    [SerializeField] private float rotationSpeed = 5.0f;
    [SerializeField] private float maxVerticalAngle = 80.0f;
    [SerializeField] private float minVerticalAngle = -80.0f;


    private float _rotationX = 0.0f;
    private float _rotationY = 0.0f;

    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Vector3 eulerAngles = transform.eulerAngles;
        _rotationX = eulerAngles.y;
        _rotationY = -eulerAngles.x;
        _rotationY = ClampAngle(_rotationY, minVerticalAngle, maxVerticalAngle);
    }

    void Update()
    {
        rotationGun();
    }
}