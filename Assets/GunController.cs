using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speedRotationGun;

    // Макс./Мин. углы поворота
    [SerializeField] private float _maxVerticalAngle = 80.0f;
    [SerializeField] private float _minVerticalAngle = -80.0f;
    //Старовый наклон орудия
    private float _rotationX = 0.0f;
    private float _rotationY = 0.0f;

    void Start()
    {
        Vector3 eulerAngles = transform.eulerAngles;
        _rotationX = eulerAngles.y;
        _rotationY = -eulerAngles.x;
        _rotationY = ClampAngle(_rotationY, _minVerticalAngle, _maxVerticalAngle);
    }

    private void Update()
    {
        rotationGun();
    }

    protected void rotationGun()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        _rotationX += mouseX * _speedRotationGun;
        _rotationY -= mouseY * _speedRotationGun;

        _rotationY = ClampAngle(_rotationY, _minVerticalAngle, _maxVerticalAngle);
        Debug.Log(_rotationY);
        // Применяем вращение
        transform.rotation = Quaternion.Euler(_rotationY, _rotationX, 0);
    }

    protected float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}
