using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class zero : MonoBehaviour
{
    public static bool moveC2 = false;
    public static bool moveC3 = false;
    public static bool moveC4 = false;
    public static bool moveC5 = false;
    public static bool moveC6 = false;
    public static bool moveC7 = false;
    public static bool moveC8 = false;
    public static bool moveC9 = false;
    public static bool moveC10 = false;
    public static bool moveC11 = false;
    public static bool moveC12 = false;
    //public static int time = 0;
    public static Vector2 position;
    // Start is called before the first frame update
    void Start()
    {
        position = new Vector2(-3, 2);

    }
    /*private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 90), "" + (int)(time / 60) + ":" + time % 60);
    }
    */

    // Update is called once per frame
    void Update()
    {
        //time += 1;
        //receives if the two sprite has been clicked on to move to its position
        if(two.move == true)
        {
            //moves this empty/zero sprite to the conduit sprite of two(C2)
            transform.position = C2.position;
            position = transform.position;
            Debug.Log("IN ZERO POS" + position);
            moveC2 = true;
            Debug.Log(this + " moved.");
        }
        if (three.move == true)
        {
            //moves this empty/zero sprite to the conduit sprite of two(C2)
            transform.position = C3.position;
            position = transform.position;
            moveC3 = true;
            Debug.Log(this + " moved.");
        }

        if (four.move == true)
        {
            //moves this empty/zero sprite to the conduit sprite of two(C2)
            transform.position = C4.position;
            position = transform.position;
            moveC4 = true;
            Debug.Log(this + " moved.");
        }

        if (five1.move == true)
        {
            //moves this empty/zero sprite to the conduit sprite of two(C2)
            transform.position = C5.position;
            position = transform.position;
            moveC5 = true;
            Debug.Log(this + " moved.");
        }

        if (six.move == true)
        {
            //moves this empty/zero sprite to the conduit sprite of two(C2)
            transform.position = C6.position;
            position = transform.position;
            moveC6 = true;
            Debug.Log(this + " moved.");
        }
        if (seven.move == true)
        {
            //moves this empty/zero sprite to the conduit sprite of two(C2)
            transform.position = C7.position;
            position = transform.position;
            moveC7 = true;
            Debug.Log(this + " moved.");
        }
        if (eight.move == true)
        {
            //moves this empty/zero sprite to the conduit sprite of two(C2)
            transform.position = C8.position;
            position = transform.position;
            moveC8 = true;
            Debug.Log(this + " moved.");
        }
        if (nine.move == true)
        {
            //moves this empty/zero sprite to the conduit sprite of two(C2)
            transform.position = C9.position;
            position = transform.position;
            moveC9 = true;
            Debug.Log(this + " moved.");
        }
        if (ten.move == true)
        {
            //moves this empty/zero sprite to the conduit sprite of two(C2)
            transform.position = C10.position;
            position = transform.position;
            moveC10 = true;
            Debug.Log(this + " moved.");
        }
        if (eleven.move == true)
        {
            //moves this empty/zero sprite to the conduit sprite of two(C2)
            transform.position = C11.position;
            position = transform.position;
            moveC11= true;
            Debug.Log(this + " moved.");
        }
        if (twelve.move == true)
        {
            //moves this empty/zero sprite to the conduit sprite of two(C2)
            transform.position = C12.position;
            position = transform.position;
            moveC12 = true;
            Debug.Log(this + " moved.");
        }


    }


}

