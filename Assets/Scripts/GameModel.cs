using System;
using System.Collections;
using System.Collections.Generic;

public class GameModel
{

    public int _premierDé;
    public int _secondDé;
    public int _troisiemeDé;

    public bool _joueur1;

    public int _scoreJ1;
    public int _scoreJ2;

    Random rand = new Random();

    public GameModel()
    {
        
    }

    public void Tirage()
    {
        if (_joueur1)
        {
            //On tire 3 dés pour le premier joueur
            _premierDé = rand.Next(1, 7);
            _secondDé = rand.Next(1, 7);
            _troisiemeDé = rand.Next(1, 7);

            
        }
        else
        {
            //On tire 3 dés pour le second joueur
            _premierDé = rand.Next(1, 7);
            _secondDé = rand.Next(1, 7);
            _troisiemeDé = rand.Next(1, 7);
        }
        
        
    }


    public void VerifyPaire()
    {
        //On vérifie sur c'est le joueur 1 ou le joueur 2 qui joue
        if (_joueur1)
        {
            if (_premierDé == _secondDé || _premierDé == _troisiemeDé)
            {

                //On ajoute la valeur du dé au score
                _scoreJ1 += _premierDé;
            }
            else if (_secondDé == _troisiemeDé)
            {
                _scoreJ1 += _troisiemeDé;
            }
        }
        else
        {
            if (_premierDé == _secondDé || _premierDé == _troisiemeDé)
            {
                _scoreJ2 += _premierDé;
            }
            else if (_secondDé == _troisiemeDé)
            {
                _scoreJ2 += _troisiemeDé;
            }
        }

    }

    public void VerifyBrelan()
    {
        if (_joueur1)
        {
            if (_premierDé == _secondDé && _secondDé == _troisiemeDé)
            {
                _scoreJ1 += 2 * _premierDé;
            }
        }
        else
        {
            if (_premierDé == _secondDé && _secondDé == _troisiemeDé)
            {
                _scoreJ2 += 2 * _premierDé;
            }
        }
    }

    public void VerifySuite()
    {

    }

    public void VerifyCochon()
    {
        if (_joueur1)
        {
            if ((_premierDé != _secondDé && _premierDé != _troisiemeDé && _secondDé != _troisiemeDé)
         && (_premierDé == 1 || _premierDé == 3 || _premierDé == 6)
         && (_secondDé == 1 || _secondDé == 3 || _secondDé == 6)
         && (_troisiemeDé == 1 || _troisiemeDé == 3 || _troisiemeDé == 6))
            {
                _scoreJ1 += 20;
            }
        }
        else
        {
            if ((_premierDé != _secondDé && _premierDé != _troisiemeDé && _secondDé != _troisiemeDé)
         && (_premierDé == 1 || _premierDé == 3 || _premierDé == 6)
         && (_secondDé == 1 || _secondDé == 3 || _secondDé == 6)
         && (_troisiemeDé == 1 || _troisiemeDé == 3 || _troisiemeDé == 6))
            {
                _scoreJ2 += 20;
            }
        }
        
    }

    public void SwitchPlayer()
    {
        //C'est le principe du tour par tour, on change de joueur 
        _joueur1 = !_joueur1;
    }

}
