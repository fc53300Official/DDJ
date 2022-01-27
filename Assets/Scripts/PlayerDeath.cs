using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour{
    Animator transition;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Trap")) {
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;
            
            if(sceneName == "Level2")
            {
                GameManager.ChangeLevel(2);
            }
            else
            {
                GameManager.ChangeLevel(1);
            }

            GameManager.ChangeScene(GameManager.gameOverScene);
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;

            if (sceneName == "Level2")
            {
                GameManager.ChangeLevel(2);
            }
            else
            {
                GameManager.ChangeLevel(1);
            }

            if (GameManager.currentLevel == 1)
            {
                //GameManager.ChangeScene(GameManager.levelScene);
                //LevelLoader.LoadNextLevel();
                //transition.SetTrigger("Finished");
                LoadNextLevel();
            }
            else
            {
                GameManager.ChangeScene(GameManager.victoryScene);
            }
            
        }
    }


    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(2));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        Animator transitionParent = gameObject.GetComponentInParent<Animator>();

        transitionParent.SetTrigger("Start");

        yield return new WaitForSeconds(0);

        SceneManager.LoadScene(levelIndex);
    }
}
