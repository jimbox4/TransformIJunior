using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localPosition += new Vector3(_speed * Time.deltaTime, 0, 0);
    }
}
