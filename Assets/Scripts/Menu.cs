using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void Restart()
    {
        GameManager.ChangeScene(GameManager.levelScene);
    }

    public void GoToMenu()
    {
        GameManager.ChangeScene(GameManager.startScene);
    }
}
