using System;
using System.Collections;
using System.Collections.Generic;

public class GameModel
{
    public int[] _faces;

    public int _premierD�;
    public int _secondD�;
    public int _troisiemeD�;

    public bool _joueur1;

    public int _scoreJ1;
    public int _scoreJ2;

    Random rand = new Random();

    public GameModel()
    {
        for (int i = 0; i < 6; i++)
        {
            _faces[i] = i + 1;
        }

        
    }

    public void VerifyPaire()
    {
        if (_joueur1)
        {
            if (_premierD� == _secondD� || _premierD� == _troisiemeD�)
            {
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

    }

    public void Tirage()
    {
        if (_joueur1)
        {
            _premierD� = rand.Next(1, 7);
            _secondD� = rand.Next(1, 7);
            _troisiemeD� = rand.Next(1, 7);
        }
        else
        {
            _premierD� = rand.Next(1, 7);
            _secondD� = rand.Next(1, 7);
            _troisiemeD� = rand.Next(1, 7);
        }
        _joueur1 = !_joueur1;
    }

}
