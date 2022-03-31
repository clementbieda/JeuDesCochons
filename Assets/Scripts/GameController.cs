using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private ScoreJ1View _scoreJ1View;
    [SerializeField] private ScoreJ2View _scoreJ2View;

    private GameModel _gameModel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShotJ1()
    {
        Debug.Log("Joueur 1 qui tire !");

    }

    public void ShotJ2()
    {
        Debug.Log("Joueur 2 qui tire !");
    }
}
