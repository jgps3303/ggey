using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    [SerializeField] float force;
    [SerializeField] float x =1;
    [SerializeField] float y =1;
    void OnTriggerStay2D(Collider2D other)
    {
        print("true");
        other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(x,y)*force*Time.deltaTime,ForceMode2D.Impulse);
    }
}
