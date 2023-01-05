using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour,IMove
{
    [SerializeField] GameObject Eggy;
    [SerializeField] GameObject Yolkie;
    bool top = false;

    [SerializeField] float topPosition;
    [SerializeField] float downPosition;

    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        MoveAroundTrap();
        Eggy = GameObject.Find("Eggy");
        Yolkie = GameObject.Find("Yolkie");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag =="Yolkie")
        {
            Destroy(Yolkie);
        }
        if(other.gameObject.tag =="Eggy")
        {
            Destroy(Eggy);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag =="Yolkie")
        {
            Destroy(Yolkie);
        }
        if(other.gameObject.tag =="Eggy")
        {
            Destroy(Eggy);
        }
    }

    public void Move()
    {
        StartCoroutine("Down");
    }
    public void MoveAroundTrap()
    {
        StartCoroutine("MoveAround");
    }

    IEnumerator Down()
    {
        while(gameObject.transform.position.y>-3.5f)
        {
            transform.Translate(Vector3.down * Time.deltaTime*0.5f);
            yield return null;
        }
        yield return null;
    }
    IEnumerator MoveAround()
    {
        while(true)
        {
            if(top)
            {
                while(gameObject.transform.position.y>=downPosition)
                {
                    transform.Translate(Vector3.down * Time.deltaTime*speed);
                    yield return null;
                }
                top = false;
            }
            if(top == false)
            {
                while(gameObject.transform.position.y<=topPosition)
                {
                    transform.Translate(Vector3.up * Time.deltaTime*speed);
                    yield return null;
                }
                top = true;
            }
            yield return null;
        }
        // yield return null;
    }
}
