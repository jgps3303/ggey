using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquColider : MonoBehaviour
{
    [HideInInspector] public bool[] con = new bool[2];

    string whoAmI;

    LiquMove m_LiquMove;
    // Start is called before the first frame update

    void Start()
    {
        whoAmI = gameObject.tag;
        m_LiquMove = GetComponentInParent<LiquMove>();
    }
    void Update()
    {
        if((con[0]&&con[1]))
        {
            print("end");
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag != gameObject.tag &&other.gameObject.layer!=3)
        {
            con[0]= true;
        }
        if(whoAmI == "Yolkie" && other.gameObject.tag == "wall")
        {
            m_LiquMove.canClimb = true;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if(whoAmI == "Yolkie" && other.gameObject.tag == "wall")
        {
            m_LiquMove.canClimb = false;
        }
    }
}
