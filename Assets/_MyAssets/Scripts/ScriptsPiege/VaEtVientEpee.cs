using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaEtVientEpee : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    [SerializeField] private Vector3 pointA = new Vector3(0, 0, 0);
    [SerializeField] private Vector3 pointB = new Vector3(0, 0, 0);

    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
