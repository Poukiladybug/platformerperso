using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Next_level : MonoBehaviour
{
    // Une autre manière de changer de scène:
    

    public UnityEvent whenPlayerWins;
    public bool ouvert = true;
    public Sprite doorOPen;
    public Sprite doorClosed;


    void Start()
    {
        if (ouvert)
        {
            GetComponent<SpriteRenderer>().sprite = doorOPen;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = doorClosed;
        }
    }



   



    //public string destination;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && ouvert)
        {
            //SceneManager.LoadScene(destination);
            whenPlayerWins?.Invoke();
        }
    }

    public void Unlock()
    {
        ouvert = true;
        GetComponent<SpriteRenderer>().sprite = doorOPen;
    }
}
