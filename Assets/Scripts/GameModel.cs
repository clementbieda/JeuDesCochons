using System.Collections;
using System.Collections.Generic;

public class GameModel
{
    public int[] _faces;

    public GameModel()
    {
        for (int i = 0; i < 6; i++)
        {
            _faces[i] = i + 1;
        }
    }


}