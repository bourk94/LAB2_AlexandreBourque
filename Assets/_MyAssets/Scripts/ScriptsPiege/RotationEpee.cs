using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationEpee : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesseRotation = -2f;

    void FixedUpdate()
    {
        transform.Rotate(0f, 0f, _vitesseRotation);
    }
}
