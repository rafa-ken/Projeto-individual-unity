using UnityEngine;

public static class GameController
{
    private static int collectableCount;
    public static int collected = 0;

    public static bool gameover
    {
        get { return collectableCount <= 0; }
    }

    public static void Init()
    {
        collectableCount = 4;
        collected = 0;
    }

    public static void Collecte()
    {
        collectableCount--;
        collected++;
    }
}