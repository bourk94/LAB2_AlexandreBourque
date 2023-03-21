using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    // Attributs
    private GameManager _gameManager;
    private bool _toucher;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _toucher = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!_toucher && collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            _gameManager.AugmenterPointage();
            _toucher = true;
        }
    }
}
