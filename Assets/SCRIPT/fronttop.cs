using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fronttop : MonoBehaviour
{
    [SerializeField] Transform Parent;
    [SerializeField] float speed;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Parent.position, -Vector3.back, speed*Time.deltaTime);
    }
}
