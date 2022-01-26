using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Trap")) {
            GameManager.ChangeScene(GameManager.gameOverScene);
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            GameManager.ChangeScene(GameManager.victoryScene);
        }
    }
}
