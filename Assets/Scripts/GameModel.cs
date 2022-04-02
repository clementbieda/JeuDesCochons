using System;
using System.Collections;
using System.Collections.Generic;

public class GameModel
{

    public int _premierD�;
    public int _secondD�;
    public int _troisiemeD�;

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
            //On tire 3 d�s pour le premier joueur
            _premierD� = rand.Next(1, 7);
            _secondD� = rand.Next(1, 7);
            _troisiemeD� = rand.Next(1, 7);

            
        }
        else
        {
            //On tire 3 d�s pour le second joueur
            _premierD� = rand.Next(1, 7);
            _secondD� = rand.Next(1, 7);
            _troisiemeD� = rand.Next(1, 7);
        }
        
        
    }


    public void VerifyPaire()
    {
        //On v�rifie sur c'est le joueur 1 ou le joueur 2 qui joue
        if (_joueur1)
        {
            if (_premierD� == _secondD� || _premierD� == _troisiemeD�)
            {

                //On ajoute la valeur du d� au score
                _scoreJ1 += _premierD�;
            }
            else if (_secondD� == _troisiemeD�)
            {
                _scoreJ1 += _troisiemeD�;
            }
        }
        else
        {
            if (_premierD� == _secondD� || _premierD� == _troisiemeD�)
            {
                _scoreJ2 += _premierD�;
            }
            else if (_secondD� == _troisiemeD�)
            {
                _scoreJ2 += _troisiemeD�;
            }
        }

    }

    public void VerifyBrelan()
    {
        if (_joueur1)
        {
            if (_premierD� == _secondD� && _secondD� == _troisiemeD�)
            {
                _scoreJ1 += 2 * _premierD�;
            }
        }
        else
        {
            if (_premierD� == _secondD� && _secondD� == _troisiemeD�)
            {
                _scoreJ2 += 2 * _premierD�;
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
            if ((_premierD� != _secondD� && _premierD� != _troisiemeD� && _secondD� != _troisiemeD�)
         && (_premierD� == 1 || _premierD� == 3 || _premierD� == 6)
         && (_secondD� == 1 || _secondD� == 3 || _secondD� == 6)
         && (_troisiemeD� == 1 || _troisiemeD� == 3 || _troisiemeD� == 6))
            {
                _scoreJ1 += 20;
            }
        }
        else
        {
            if ((_premierD� != _secondD� && _premierD� != _troisiemeD� && _secondD� != _troisiemeD�)
         && (_premierD� == 1 || _premierD� == 3 || _premierD� == 6)
         && (_secondD� == 1 || _secondD� == 3 || _secondD� == 6)
         && (_troisiemeD� == 1 || _troisiemeD� == 3 || _troisiemeD� == 6))
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
