using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        levelsManager levelsManager = levelsManager.instance;
        GameObject player = levelsManager.player;
        player.transform.position = transform.position;
        // ou : GameObject.FindObjectOfType<levelsManager>().player.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
