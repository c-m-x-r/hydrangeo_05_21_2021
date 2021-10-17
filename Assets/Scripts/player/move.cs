using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool xmoving = false;
    private bool ymoving = false;
    private float x_movement = 0.0f;
    private bool  touchingwall_down = false;
    private bool  touchingwall_up = false;
    private bool  touchingwall_left = false;
    private bool  touchingwall_right = false;
    private float y_movement = 0.0f;
    private float maxspeed = 0.0f;
    
    public float speed = 1.0f;

    Animator anim;
    

    void Awake()
    {
    maxspeed = speed;
    //adds rigidbody on its own
        rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    void Start()
    {
       //no need to load sprite
        gameObject.transform.Translate(0.0f, 0.0f, 0.0f);
        anim = GetComponent<Animator>();
    }

    

    void Update()
    {
    
    if (gameObject.transform.position[0] > 9.4)
    {
        touchingwall_right = true;
    }
    else if(gameObject.transform.position[0] < 0.6)
    {
        touchingwall_left = true;
    }

    if (gameObject.transform.position[1] > 13.7)
    {
        touchingwall_up = true;
    }
    else if(gameObject.transform.position[1] < 2.0)
    {
        touchingwall_down = true;
    }




        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxspeed= speed/2f;
        }
        else
        {
          maxspeed =speed;
        }


        //Press the arrow keys to move 
        if (Input.GetKey(KeyCode.UpArrow) && !touchingwall_up)
        {
            y_movement = 0.01f;
            ymoving = true;

            touchingwall_down = false;
        }
       
        else if (Input.GetKey(KeyCode.DownArrow) && !touchingwall_down)
        {
            y_movement = -0.01f;
           ymoving = true;

           touchingwall_up = false;
        }
      else { ymoving = false;}

      if (Input.GetKey(KeyCode.RightArrow) && !touchingwall_right)
        {
            x_movement = 0.01f;
            xmoving = true;

            touchingwall_left = false;
        }
      

      else if (Input.GetKey(KeyCode.LeftArrow) && !touchingwall_left)
        {
            x_movement = -0.01f;
            xmoving = true;

            touchingwall_right= false;
        }

        else { xmoving = false;}


        if (xmoving == false)
        {
            x_movement = 0.0f;
        }
        if (ymoving == false)
        {
            y_movement = 0.0f;
        }
   //Debug.Log(gameObject.transform.position[0]);
   
        //Debug.Log(gameObject.transform.position.y + " : " + "x is moving: " + xmoving + "  y is moving: "+ ymoving + "maxspeed" + maxspeed);
        
        if (xmoving || ymoving)
        {

       rb.MovePosition(new Vector2(maxspeed * x_movement, maxspeed * y_movement) + rb.position);
        
        }
        
    }
}