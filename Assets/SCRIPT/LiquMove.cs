using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D[] bone;

    [SerializeField] float speed;


    // Start is called before the first frame update
    void Start()
    {

        bone = gameObject.GetComponentsInChildren<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float axix = Input.GetAxisRaw("Horizontal");
        if(axix != 0)
        {
            for (int i = 0; i < bone.Length - 1;i++)
            {
                print(axix);
                bone[i].AddForce(new Vector2(axix * speed, 0));
            }
        }
    }
}
