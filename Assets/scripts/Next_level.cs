using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Next_level : MonoBehaviour
{
    // Une autre manière de changer de scène:


    public UnityEvent whenPlayerWins;
    


    void Start()
    {
        
    }

   



    public string destination;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //SceneManager.LoadScene(destination);
            whenPlayerWins?.Invoke();
        }
    }
}
