using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    [SerializeField] private float _growSpeed;

    private void Update()
    {
        transform.localScale += _growSpeed * Time.deltaTime * Vector3.one;
    }
}
