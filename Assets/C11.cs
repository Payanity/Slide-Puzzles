﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C11 : MonoBehaviour
{
    public static Vector2 position;
    private Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
        position = new Vector2((float)0.6, (float)-1.6);
    }

    // Update is called once per frame
    void Update()
    {
        //Moves this conduit sprite to the position of two...for some reason it 
        //moves it before the zero is moved to the position of two but after two is 
        //moved to the position of zero so we have it move to the zero's OGer position
        //(where the two moves to, so it moves with it) instead of the two's 
        //"FIN"er position
        if (zero.moveC11 == true)
        {
            //the target is on the zero block because it's before it moves
            target = eleven.position;
            Debug.Log("ZERO POS:" + zero.position);
            transform.position = target;
            position = transform.position;
            zero.moveC11 = false;
            Debug.Log(this + " moved.");

        }
        //Debug.Log("ZERO POS:" + zero.position);
    }
}
