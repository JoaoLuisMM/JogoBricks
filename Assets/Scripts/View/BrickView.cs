using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickView : MonoBehaviour
{
    private BrickController __brickController;
    
    public Color[] color;

    void Start()
    {
        __brickController = GetComponent<BrickController>();
    }

}
