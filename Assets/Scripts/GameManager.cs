using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static int levelScene = 0;
    public static int gameOverScene = 1;
    public static int startScene = 2;
    public static int victoryScene = 3;

    public static void ChangeScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
