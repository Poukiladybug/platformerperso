using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelsManager : MonoBehaviour
{

    public static levelsManager instance = null; /*variable pour se stocker sois même. Static peut être modifié et sera modifié partout en consquent*/
    public GameObject playerPrefab;
    public GameObject player;
    public static int lifes = 3;
    public static bool fall = false;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
            player = Instantiate(playerPrefab);
            DontDestroyOnLoad(player);
        }
        else
        {
            Destroy(gameObject);
        }


    }
   
    public static void LoseLife() /* Static on peu ty accéder sans instancié la classe.  On ne peut y utiliser que des éléments statiques dedans...  (Je piges pas, du coup regarde sur internet pour comprendre duchmoul!)*/ 
        {
        lifes--;
        if (lifes <= 0)
        {
            SceneManager.LoadScene("GameOver");
            lifes = 3;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        print(lifes);
        
        }

    



}
