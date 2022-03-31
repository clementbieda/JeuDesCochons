using System;
using System.Collections;
using System.Collections.Generic;

public class GameModel
{
    public int[] _faces;

    public int _premierDé;
    public int _secondDé;
    public int _troisiemeDé;

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
            if (_premierDé == _secondDé || _premierDé == _troisiemeDé)
            {
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

    }

    public void Tirage()
    {
        if (_joueur1)
        {
            _premierDé = rand.Next(1, 7);
            _secondDé = rand.Next(1, 7);
            _troisiemeDé = rand.Next(1, 7);
        }
        else
        {
            _premierDé = rand.Next(1, 7);
            _secondDé = rand.Next(1, 7);
            _troisiemeDé = rand.Next(1, 7);
        }
        _joueur1 = !_joueur1;
    }

}
