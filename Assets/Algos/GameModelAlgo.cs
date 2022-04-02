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
*/