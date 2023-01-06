using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    [SerializeField] float force;
    void OnTriggerStay2D(Collider2D other)
    {
        print("true");
        other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1,1)*force*Time.deltaTime,ForceMode2D.Impulse);
    }
}
