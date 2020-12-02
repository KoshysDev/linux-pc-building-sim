using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public GameObject target;

    private float _speed = 5f;

    private float _minFov = 35f;
    private float _maxFox = 100f;

    private float _sens = 17f;

    private void Update()
    {
        if (Input.GetMouseButton(2))
        {
            transform.RotateAround(target.transform.position, transform.up, Input.GetAxis("Mouse X") * _speed);
            //transform.RotateAround(target.transform.position, transform.right, Input.GetAxis("Mouse Y") * _speed);
        }

        float fov = Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * -_sens;
        fov = Mathf.Clamp(fov, _minFov, _maxFox);
        Camera.main.fieldOfView = fov;
    }
}
