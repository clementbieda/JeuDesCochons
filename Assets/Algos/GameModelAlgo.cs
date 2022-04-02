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
*/