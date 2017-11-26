using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

enum KeyCommandState { Idle, KeyInput };

//오른쪽 플레이어 기준

public struct KKeyCommand
{
    readonly static double interKeyTime = 0.2;
    public string commandString;
    int keyCursor;
    KeyCommandState keyState;
    double keyTimer;

    public KKeyCommand(string command_)
    {
        commandString = command_;
        keyCursor = 0;
        keyState = KeyCommandState.Idle;
        keyTimer = 0.0;
    }//KKeyCommand

    public bool ProcessKey(char key)
    {

        if (keyCursor >= commandString.Length)
        {
            //keyCursor += 1;
            return false;
        }//if

        if (commandString[keyCursor] == key)
        {
            if (keyCursor == 0)
            {
                // move to 'KeyInput' state from 'Idle'
                keyState = KeyCommandState.KeyInput;
            }//if
            keyCursor += 1; // move to next key
            keyTimer = 0.0; // reset valid key input timer
            if (keyCursor == commandString.Length)
            {
                // this key command is matched
                return true;
            }//if
        }//if

        return false;
    }//ProcessKey()

    // must be called for each 'Update()'
    public void Update(double elapsedTime_)
    {
        keyTimer += elapsedTime_;
        if (keyTimer >= interKeyTime)
        {
            // move to 'Idle' state if timer expire
            keyState = KeyCommandState.Idle;
            keyCursor = 0;
            keyTimer = 0.0;
        }//if
    }//Update()

    // check this key command is triggered or not.
    public bool IsTrigger()
    {
        if (keyState == KeyCommandState.KeyInput && keyCursor == commandString.Length)
        {
            return true;
        }//if

        return false;
    }//IsTrigger()

    public int GetCursor()
    {
        return keyCursor;
    }//GetCursor()
};//struct KKeyCommand



public class CKeyCommand : MonoBehaviour
{
    //readonly static double  inputThreshold = 0.05; // NOT used in this demo, maybe required if you use a joystick.
    KKeyCommand[] keyCommands;


    // for showing key command success.
    // when key command is triggered, we will add force to upward.
    // - jintaeks on 2017-03-21_15-56
    Rigidbody rigidBody;

    CPlayerCtrl player;

    private float fDestroyTime = 5f;
    private float fTickTime;


    // Use this for initialization
    void Start()
    {
        keyCommands = new KKeyCommand[]
        {
            new KKeyCommand("LR"),
            new KKeyCommand("LDR"),
            new KKeyCommand("UD"),
            new KKeyCommand("LRLRD"),
        };//keyCommands[]

        rigidBody = GetComponent<Rigidbody>();
        player = GameObject.Find("pref_Miho_Right").GetComponent<CPlayerCtrl>();
        Invoke("CommandKey_init", 0.5f);


    }//Start()

    void FixedUpdate()
    {


        for (int i = 0; i < keyCommands.Length; ++i)
        {
            if (keyCommands[i].IsTrigger() == true)
            {

            }//if
        }//for


    }//FixedUpdate()

    // Update is called once per frame
    void Update()
    {

        // @caution DO NOT USE FOREACH!
        // foreach copies instance in container
        // - jintaeks on 2017-03-21_15-37
        //foreach( KKeyCommand command in keyCommands )

        for (int i = 0; i < keyCommands.Length; ++i)
        {

            if (player.isNewLeftKey)
                keyCommands[i].ProcessKey('L');
            if (player.isNewRightKey)
                keyCommands[i].ProcessKey('R');
            if (player.isNewUpKey)
                keyCommands[i].ProcessKey('U');
            if (player.isNewDownKey)
                keyCommands[i].ProcessKey('D');


            //    if (isNewLeftUpKey)
            //        keyCommands[i].ProcessKey('Q');
            //    if (isNewRightUpKey)
            //        keyCommands[i].ProcessKey('E');
            //    if (isNewLeftDownKey)
            //        keyCommands[i].ProcessKey('Z');
            //    if (isNewRightDownKey)
            //        keyCommands[i].ProcessKey('C');

            keyCommands[i].Update(Time.deltaTime);

        }//foreach

    }

}//Update()

    */