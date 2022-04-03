/*
Algo : Tirage
    #On va tirer aléatoirement 3 chiffre (un par dé) entre 1 et 6

Variables
    _premierDé : ENTIER
    _secondDé : ENTIER
    _troisiemeDé : ENTIER
    
    _joueur1 : BOOLEEN

    _scoreJ1 : ENTIER
    _scoreJ2 : ENTIER

Realisation
    Si (_joueur1) Alors
        _premierDé <- rand.Suivant(1,7) // on tire un chiffre aléatoire entre 1 et 6
        _secondDé <- rand.Suivant(1,7)
        _troisiemeDé <- rand.Suivant(1,7)
    Sinon
        _premierDé <- rand.Suivant(1,7)
        _secondDé <- rand.Suivant(1,7)
        _troisiemeDé <- rand.Suivant(1,7)
    Fin Si

----------

Algo : VerifyPaire
    #verifie si le résultat du tirage est une paire

Variables
    _premierDé : ENTIER
    _secondDé : ENTIER
    _troisiemeDé : ENTIER

    _joueur1 : BOOLEEN

    _scoreJ1 : ENTIER
    _scoreJ2 : ENTIER

Realisation
    Si (_scoreJ1 < 30) Alors
        Si (_joueur1) Alors
            Si (_premierDé = _secondDé OU _premierDé = _troisiemeDé) Alors
                _scoreJ1 <- _scoreJ1 + _premierDé
            Sinon Si (_secondDé = _troisiemeDé) Alors
                _scoreJ1 <- _scoreJ1 + _troisiemeDé
            Fin Si
        Fin Si
    Sinon Si (_scoreJ2 < 30) Alors
        Si (NON(_joueur1) Alors
            Si (_premierDé = _secondDé OU _premierDé = _troisiemeDé) Alors
                _scoreJ2 <- _scoreJ2 + _premierDé
            Sinon Si (_secondDé = _troisiemeDé) Alors
                _scoreJ2 <- _scoreJ2 + _troisiemeDé
            Fin Si
        Fin Si
    Fin Si

----------

Algo : VerifyBrelan
    #verifie si le résultat du tirage est un brelan

Variables
    _premierDé : ENTIER
    _secondDé : ENTIER
    _troisiemeDé : ENTIER

    _joueur1 : BOOLEEN

    _scoreJ1 : ENTIER
    _scoreJ2 : ENTIER

Realisation
    Si (_scoreJ1 < 30) Alors
        Si (_joueur1) Alors
            Si (_premierDé = _secondDé ET _secondDé = _troisiemeDé) Alors
                _scoreJ1 <- _scoreJ1 + _premierDé
            Fin Si
        Fin Si
    Sinon Si (_scoreJ2 < 30) Alors
        Si (NON(_joueur1) Alors
            Si (_premierDé = _secondDé ET _secondDé = _troisiemeDé) Alors
                _scoreJ2 <- _scoreJ2 + _premierDé
            Fin Si
        Fin Si
    Fin Si

----------

Algo : VerifyCochon
    #verifie si le résultat du tirage est un cochon

Variables
    _premierDé : ENTIER
    _secondDé : ENTIER
    _troisiemeDé : ENTIER

    _joueur1 : BOOLEEN

    _scoreJ1 : ENTIER
    _scoreJ2 : ENTIER

Realisation
    Si (_scoreJ1 < 30) Alors
        Si (_joueur1) Alors
            Si ((_premierDé != _secondDé ET _premierDé != _troisiemeDé ET _secondDé != _troisiemeDé)
            ET (_premierDé = 1 OU _premierDé = 3 OU _premierDé = 6)
            ET (_secondDé = 1 OU _secondDé = 3 OU _secondDé = 6) 
            ET (_troisiemeDé = 1 OU _troisiemeDé = 3 OU _troisiemeDé = 6)) Alors
                _scoreJ1 <- _scoreJ1 + 20
            Fin Si
        Fin Si
    Sinon Si (_scoreJ2 < 30) Alors
        Si (NON(_joueur1) Alors
            Si ((_premierDé != _secondDé ET _premierDé != _troisiemeDé ET _secondDé != _troisiemeDé)
            ET (_premierDé = 1 OU _premierDé = 3 OU _premierDé = 6)
            ET (_secondDé = 1 OU _secondDé = 3 OU _secondDé = 6) 
            ET (_troisiemeDé = 1 OU _troisiemeDé = 3 OU _troisiemeDé = 6)) Alors
                _scoreJ2 <- _scoreJ2 + 20
            Fin Si
        Fin Si
    Fin Si

----------

Algo : SwitchPlayer
    #change de joueur

Variables
    _joueur1 : BOOLEEN

Realisation
    _joueur1 <- NON(_joueur1)
*/