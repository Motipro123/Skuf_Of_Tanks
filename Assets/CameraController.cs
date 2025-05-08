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
        //float mouseX = Input.GetAxis("Mouse X");
        //float mouseY = Input.GetAxis("Mouse Y");

        //_rotationX += mouseX * rotationSpeed;
        //_rotationY -= mouseY * rotationSpeed;

        //_rotationY = ClampAngle(_rotationY, minVerticalAngle, maxVerticalAngle);
        //Debug.Log(_rotationY);
        //// Применяем вращение
        //transform.rotation = Quaternion.Euler(_rotationY, _rotationX, 0);
    }
}