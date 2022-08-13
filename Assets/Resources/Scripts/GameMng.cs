using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMng
{
    static GameMng Ins;
    public static GameMng GetIns
    {
        get
        {
            if (Ins == null)
                Ins = new GameMng();
            return Ins;
        }
    }
    public bool GameStart = false;
}
