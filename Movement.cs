using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class Movement : MonoBehaviour
{

    public float Speed = 25f;
    private InputHandler inputHandler;

    Vector2 Direction;
    // Start is called before the first frame update
    void Start()
    {
        inputHandler = GetComponent<InputHandler>();
        
        if (inputHandler == null)
        {
            inputHandler = FindObjectOfType<InputHandler>();
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        Direction = Vector2.zero;

        if (inputHandler.moveUp) {
            Direction += Vector2.up;    
        }
        if (inputHandler.moveDown) {
            Direction += Vector2.down;
        }
        if (inputHandler.moveLeft) {
            Direction += Vector2.left;
        }
        if (inputHandler.moveRight) {
            Direction += Vector2.right;
        }
        Direction = Direction.normalized * Speed * Time.deltaTime;
        if (inputHandler.shiftRun) {
            Direction *= 2;
        }
        transform.Translate(Direction);
    }

}
