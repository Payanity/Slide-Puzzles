using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class four : MonoBehaviour
{

    // Start is called before the first frame update
    private float speed = 100.0f;
    private Vector2 target;
    public static Vector2 position;
    private Camera cam;
    private bool booler = false;
    public static bool move = false;
    public Collider2D objCollider;
    public Collider2D anoCollider;

    void Start()
    {
        target = new Vector2(0.0f, 0.0f);
        position = new Vector2((float)2.4, 2);
        cam = Camera.main;
        objCollider = GameObject.FindGameObjectWithTag("FOUR").GetComponent<Collider2D>();
        anoCollider = GameObject.FindGameObjectWithTag("ZERO").GetComponent<Collider2D>();
    }
    private void OnMouseOver()
    {
        Debug.Log("Mouse is over " + this);
        booler = true;
    }
    private void OnMouseExit()
    {
        Debug.Log("Mouse is no longer over " + this);
        booler = false;
    }

    // Update is called once per frame
    void Update()
    {
        move = false;


        if (objCollider.IsTouching(anoCollider))
        {
            //Debug.Log("COLLIDE!");
            if (Input.GetMouseButtonDown(0) && booler)
            {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D[] hits = Physics2D.RaycastAll(mousePosition, new Vector2(0, 0), 0.01f);
                target = zero.position;
                Debug.Log("Hi" + target);
                float step = speed * Time.deltaTime;

                // move sprite towards the target location ("empty" zero block)
                transform.position = target;
                position = transform.position;
                //tells the zero (empty) sprite that this sprite has moved to it
                move = true;
                Debug.Log(this + " moved.");
            }

        }


    }


}