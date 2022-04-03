/*
Algo : Tirage
    #On va tirer al�atoirement 3 chiffre (un par d�) entre 1 et 6

Variables
    _premierD� : ENTIER
    _secondD� : ENTIER
    _troisiemeD� : ENTIER
    
    _joueur1 : BOOLEEN

    _scoreJ1 : ENTIER
    _scoreJ2 : ENTIER

Realisation
    Si (_joueur1) Alors
        _premierD� <- rand.Suivant(1,7) // on tire un chiffre al�atoire entre 1 et 6
        _secondD� <- rand.Suivant(1,7)
        _troisiemeD� <- rand.Suivant(1,7)
    Sinon
        _premierD� <- rand.Suivant(1,7)
        _secondD� <- rand.Suivant(1,7)
        _troisiemeD� <- rand.Suivant(1,7)
    Fin Si

----------

Algo : VerifyPaire
    #verifie si le r�sultat du tirage est une paire

Variables
    _premierD� : ENTIER
    _secondD� : ENTIER
    _troisiemeD� : ENTIER

    _joueur1 : BOOLEEN

    _scoreJ1 : ENTIER
    _scoreJ2 : ENTIER

Realisation
    Si (_scoreJ1 < 30) Alors
        Si (_joueur1) Alors
            Si (_premierD� = _secondD� OU _premierD� = _troisiemeD�) Alors
                _scoreJ1 <- _scoreJ1 + _premierD�
            Sinon Si (_secondD� = _troisiemeD�) Alors
                _scoreJ1 <- _scoreJ1 + _troisiemeD�
            Fin Si
        Fin Si
    Sinon Si (_scoreJ2 < 30) Alors
        Si (NON(_joueur1) Alors
            Si (_premierD� = _secondD� OU _premierD� = _troisiemeD�) Alors
                _scoreJ2 <- _scoreJ2 + _premierD�
            Sinon Si (_secondD� = _troisiemeD�) Alors
                _scoreJ2 <- _scoreJ2 + _troisiemeD�
            Fin Si
        Fin Si
    Fin Si

----------

Algo : VerifyBrelan
    #verifie si le r�sultat du tirage est un brelan

Variables
    _premierD� : ENTIER
    _secondD� : ENTIER
    _troisiemeD� : ENTIER

    _joueur1 : BOOLEEN

    _scoreJ1 : ENTIER
    _scoreJ2 : ENTIER

Realisation
    Si (_scoreJ1 < 30) Alors
        Si (_joueur1) Alors
            Si (_premierD� = _secondD� ET _secondD� = _troisiemeD�) Alors
                _scoreJ1 <- _scoreJ1 + _premierD�
            Fin Si
        Fin Si
    Sinon Si (_scoreJ2 < 30) Alors
        Si (NON(_joueur1) Alors
            Si (_premierD� = _secondD� ET _secondD� = _troisiemeD�) Alors
                _scoreJ2 <- _scoreJ2 + _premierD�
            Fin Si
        Fin Si
    Fin Si

----------

Algo : VerifyCochon
    #verifie si le r�sultat du tirage est un cochon

Variables
    _premierD� : ENTIER
    _secondD� : ENTIER
    _troisiemeD� : ENTIER

    _joueur1 : BOOLEEN

    _scoreJ1 : ENTIER
    _scoreJ2 : ENTIER

Realisation
    Si (_scoreJ1 < 30) Alors
        Si (_joueur1) Alors
            Si ((_premierD� != _secondD� ET _premierD� != _troisiemeD� ET _secondD� != _troisiemeD�)
            ET (_premierD� = 1 OU _premierD� = 3 OU _premierD� = 6)
            ET (_secondD� = 1 OU _secondD� = 3 OU _secondD� = 6) 
            ET (_troisiemeD� = 1 OU _troisiemeD� = 3 OU _troisiemeD� = 6)) Alors
                _scoreJ1 <- _scoreJ1 + 20
            Fin Si
        Fin Si
    Sinon Si (_scoreJ2 < 30) Alors
        Si (NON(_joueur1) Alors
            Si ((_premierD� != _secondD� ET _premierD� != _troisiemeD� ET _secondD� != _troisiemeD�)
            ET (_premierD� = 1 OU _premierD� = 3 OU _premierD� = 6)
            ET (_secondD� = 1 OU _secondD� = 3 OU _secondD� = 6) 
            ET (_troisiemeD� = 1 OU _troisiemeD� = 3 OU _troisiemeD� = 6)) Alors
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