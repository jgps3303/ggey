using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Butten : MonoBehaviour
{
    SpriteRenderer m_SpriteRender;

    [SerializeField] Sprite next;
    [SerializeField] UnityEvent OnTrigger;
    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        OnTrigger.Invoke();
        m_SpriteRender.sprite = next;
    }
}
