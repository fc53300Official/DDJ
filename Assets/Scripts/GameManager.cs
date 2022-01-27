using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static int startScene = 0;
    public static int firstLevelScene = 1;
    public static int levelScene = 2;
    public static int gameOverScene = 3;
    public static int victoryScene = 4;
    

    public static int currentLevel = 1;

    public static void ChangeScene(int i)
    {
        SceneManager.LoadScene(i);
    }

    public static void ChangeLevel(int i)
    {
        currentLevel = i;
    }
}
