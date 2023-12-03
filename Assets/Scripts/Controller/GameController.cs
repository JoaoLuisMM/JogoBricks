using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{

    private int bricks;
    
    public string nextScene;

    void Start()
    {
        GameObject[] gm = GameObject.FindGameObjectsWithTag("brick");

        bricks = gm.Length - 1;
    }

    // Update is called once per frame
    public void DecrementaBricks()
    {
        bricks--;
        
        print(bricks);
        if(bricks <= 0){
            print(bricks);
            SceneManager.LoadScene(nextScene);
        }
    }
}
