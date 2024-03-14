using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        transform.localRotation *= Quaternion.Euler(0, _rotationSpeed * Time.deltaTime, 0);
    }
}
