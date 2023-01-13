using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquMove : MonoBehaviour,IDamageable
{
    [SerializeField] Rigidbody2D[] bone;

    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    [SerializeField] float climbSpeed;

    [SerializeField] bool[] which;

    [SerializeField] bool canJump;

    public bool canClimb=false;

    // [SerializeField] Transform m_GroundCheck;

    bool isJump;

    float currentTime;


    // Start is called before the first frame update
    void Start()
    {

        bone = gameObject.GetComponentsInChildren<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(which[0]==true)
        {
            float axix = Input.GetAxisRaw("Horizontal");
            if(axix != 0)
            {
                for (int i = 0; i < bone.Length - 1;i++)
                {
                    // print(axix);
                    bone[i].AddForce(new Vector2(axix * speed, 0)*Time.deltaTime,ForceMode2D.Force);
                }
            }
        }    
        else if(which[1]==true)
        {
            if(canClimb==false)
            {
                float axixalt = Input.GetAxisRaw("HorizontalAlt");
                if(axixalt != 0)
                {
                    for (int i = 0; i < bone.Length - 1;i++)
                    {
                        // print(axixalt);
                        bone[i].AddForce(new Vector2(axixalt * speed, 0)*Time.deltaTime,ForceMode2D.Force);
                    }
                }
            }
            if(canClimb==true)
            {
                float axixalt = Input.GetAxisRaw("Vertical");
                if(axixalt != 0)
                {
                    for (int i = 0; i < bone.Length - 1;i++)
                    {
                        // print(axixalt);
                        bone[i].AddForce(new Vector2(0,axixalt*climbSpeed)*Time.deltaTime,ForceMode2D.Force);
                    }
                }
            }
        }
        if(canJump==true && isJump==false)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                for (int i = 0; i < bone.Length - 1;i++)
                {
                    bone[i].AddForce(new Vector2(0, jumpForce)*Time.fixedDeltaTime,ForceMode2D.Impulse);
                }
                isJump = true;
                currentTime = 0;
            }
        }
        if(isJump)
        {
            currentTime += Time.deltaTime;
            if(currentTime>1f)
            {
                isJump = false;
            }
        }    
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.layer == 3)
        {
            isJump = false;
        }
    }

    public void Delete()
    {
        Destroy(gameObject);
    }
}
