using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMoulin : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesseRotation = -2f;

    void FixedUpdate()
    {
        transform.Rotate(0f, _vitesseRotation, 0f);
    }

}
