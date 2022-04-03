/*

Algo : ShotJ1
    #la fonction qui va permettre de relier le gameModel au bouton du jeu

Variables
    _gameModel : GameModel //On instancie le GameModel dans une variable pour l'utiliser en réalisation

Realisation
    Si (NON(_gameModel._joueur1) Alors
        Afficher("Joueur 1 qui tire !")
        _gameModel.Tirage()
        _gameModel.VerifyPaire()
        _gameModel.VerifyBrelan()
        _gameModel.VerifySuite()
        _gameModel.VerifyCochon()
        _gameModel.SwitchPlayer()
        
        Afficher("Les chiffres tirés sont :" + _gameModel._premierDé + " , " + _gameModel._secondDé + " , " + _gameModel._troisiemeDé)
        Afficher("Score du joueur 1 : " + _gameModel._scoreJ1)


Algo : ShotJ2
    #la fonction qui va permettre de relier le gameModel au bouton du jeu

Variables
    _gameModel : GameModel //On instancie le GameModel dans une variable pour l'utiliser en réalisation

Realisation
    Si (_gameModel._joueur1) Alors
        Afficher("Joueur 2 qui tire !")
        _gameModel.Tirage()
        _gameModel.VerifyPaire()
        _gameModel.VerifyBrelan()
        _gameModel.VerifySuite()
        _gameModel.VerifyCochon()
        _gameModel.SwitchPlayer()
        
        Afficher("Les chiffres tirés sont :" + _gameModel._premierDé + " , " + _gameModel._secondDé + " , " + _gameModel._troisiemeDé)
        Afficher("Score du joueur 2 : " + _gameModel._scoreJ1)

*/