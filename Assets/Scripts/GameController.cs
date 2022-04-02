using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private ScoreJ1View _scoreJ1View;
    [SerializeField] private ScoreJ2View _scoreJ2View;

    [SerializeField] private DiceView _diceView;

    private GameModel _gameModel;
    // Start is called before the first frame update
    void Start()
    {
        _gameModel = new GameModel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShotJ1()
    {
        if (!_gameModel._joueur1)
        {
            Debug.Log("Joueur 1 qui tire !");
            _gameModel.Tirage();
            _gameModel.VerifyPaire();
            _gameModel.VerifyBrelan();
            _gameModel.VerifySuite();
            _gameModel.VerifyCochon();
            _gameModel.SwitchPlayer();

            Debug.Log("Les chiffres tirés sont :" + _gameModel._premierDé + " , " + _gameModel._secondDé + " , " + _gameModel._troisiemeDé);
            Debug.Log("Score du joueur 1 : " + _gameModel._scoreJ1);
        }
        

    }

    public void ShotJ2()
    {
        if (_gameModel._joueur1)
        {
            Debug.Log("Joueur 2 qui tire !");
            _gameModel.Tirage();
            _gameModel.VerifyPaire();
            _gameModel.VerifyBrelan();
            _gameModel.VerifySuite();
            _gameModel.VerifyCochon();
            _gameModel.SwitchPlayer();

            Debug.Log("Les chiffres tirés sont :" + _gameModel._premierDé + " , " + _gameModel._secondDé + " , " + _gameModel._troisiemeDé);
            Debug.Log("Score du joueur 2 : " + _gameModel._scoreJ2);
        } 
    }
}
