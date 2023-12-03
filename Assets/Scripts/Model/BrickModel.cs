using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickModel : MonoBehaviour

{
    [SerializeField] private float __life;
    [SerializeField] private AudioClip __balloonPop;
    [SerializeField] private Color[] __color;


    public float Life
    {
        get => __life;
        set => __life = value;
    
    }

    public AudioClip BalloonPop
    {
        get => __balloonPop;
        set => __balloonPop = value;
    }
}
