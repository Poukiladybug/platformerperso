using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class key : MonoBehaviour
{
    public UnityEvent whenPickUp;
    //private Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            whenPickUp?.Invoke();
            GameObject.Destroy(gameObject);
            
        }
    }
}
