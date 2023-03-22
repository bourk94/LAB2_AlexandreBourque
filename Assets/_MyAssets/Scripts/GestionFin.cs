using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionFin : MonoBehaviour
{
    // Attributs
    private GameManager _gameManager;
    private bool _toucher;
    private Player _player;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _toucher = false;
        _player = FindObjectOfType<Player>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        if (!_toucher && collision.gameObject.tag == "Player")
        {
            _player.FinPartie();
            _toucher = true;

            if (indexScene == 2)
            {
                _gameManager.TerminerPartie();
            }
            else
            {
                SceneManager.LoadScene(indexScene + 1);
            }

        }
    }
}
