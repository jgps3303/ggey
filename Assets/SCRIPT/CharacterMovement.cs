using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    CharacterController2D m_Controller;
    float horizontalmove = 0f;

    bool jump =false;

    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        m_Controller = GetComponent<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal")*speed;
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    void FixedUpdate()
    {
        m_Controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
