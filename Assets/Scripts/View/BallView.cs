using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BallView : MonoBehaviour
{
    private BallController __controllerBall;

    // Start is called before the first frame update
    void Start()
    {
        __controllerBall = GetComponent<BallController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("brick"))
        {
            __controllerBall.PerfectAngleReflect(collision);
            Brick brick = collision.gameObject.GetComponent<Brick>();
            brick.Hit();
        }
        else if (collision.gameObject.CompareTag("dead"))
        {
            RestartGame();
        }
        else if (collision.gameObject.CompareTag("wall"))
        {
            __controllerBall.PerfectAngleReflect(collision);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            print("Player");
            Vector2 direction = __controllerBall.CalcBallAngleReflect(collision);
            __controllerBall.AngleChange(direction);
        }
        
    }

   void RestartGame()
    {
        // Reload the current scene
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

}
