using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public bool moveUp;
    public bool moveDown;
    public bool moveLeft;
    public bool moveRight;
    public bool shiftRun;
    public bool saveState;
    public bool loadState;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        moveUp = Input.GetKey(KeyCode.W);
        moveDown = Input.GetKey(KeyCode.S);
        moveLeft = Input.GetKey(KeyCode.A);
        moveRight = Input.GetKey(KeyCode.D);
        shiftRun = Input.GetKey(KeyCode.LeftShift);
        saveState = Input.GetKey(KeyCode.F5);
        loadState = Input.GetKey(KeyCode.F6);
    }
}
