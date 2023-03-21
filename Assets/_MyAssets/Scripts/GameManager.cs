using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Attributs

    private int _pointage = 0;  // Attribut qui conserve le nombre d'accrochages
    private int _accrochage = 0;  // Atribut qui conserve le nombre d'accrochage
    private float _temps = 0.0f;  // Attribut qui conserve le temps

    // M�thodes priv�es
    private void Awake()
    {
        // V�rifie si un gameObject GameManager est d�j� pr�sent sur la sc�ne si oui
        // on d�truit celui qui vient d'�tre ajout�. Sinon on le conserve pour la 
        // sc�ne suivante.
        int nbGameManager = FindObjectsOfType<GameManager>().Length;
        if (nbGameManager > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        InstructionsDepart();  // Affiche les instructions de d�part
    }

    
     // M�thode qui affiche les instructions au d�part
    private static void InstructionsDepart()
    {
        Debug.Log("Course � obstacles");
        Debug.Log("Le but du jeu est d'atteindre la zone d'arriv�e le plus rapidement possible");
        Debug.Log("Chaque contact avec un obstable entra�nera une p�nalit� de temps de 1 seconde");
    }

    // M�thodes publiques

    
    // M�thode publique qui permet d'augmenter le pointage de 1
    public void AugmenterPointage()
    {
        _pointage++;
    }

    // Accesseur qui retourne la valeur de l'attribut pointage
    public int GetPointage()
    {
        return _pointage;
    }

    // Accesseur qui retourne le temps
    public float GetTemps()
    {
        return _temps;
    }

    public int GetAccrochages()
    {
        return _accrochage;
    }

    public void SetNiveau1(int accrochages, float temps)
    {
        _accrochage = accrochages;
        _temps = temps;
    }
}
