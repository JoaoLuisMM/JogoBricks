using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public Color[] color;

    private SpriteRenderer spriteRenderer;
    private int health;
    
    [SerializeField] private AudioClip __balloonPop;


    private BrickModel __brickModel;
    private GameController __gameobject;
    // Start is called before the first frame update
    void Start()
    {
        __gameobject = GameObject.Find("GameController").GetComponent<GameController>();
        __brickModel = GetComponent<BrickModel>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        if(color.Length == 0){
            health = 1;
        }else{
            health = color.Length;
            spriteRenderer.color = color[color.Length - 1];
        }

    }

    public void Hit()
    {
        health--;

        AudioSource.PlayClipAtPoint(__brickModel.BalloonPop, transform.position);
        if (health <= 0) {
            __gameobject.DecrementaBricks();
            Destroy(gameObject);
        } else {
            spriteRenderer.color = color[health - 1];
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball")) {
            print(collision.gameObject.tag);
        }
    }

}