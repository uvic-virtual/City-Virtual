using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoffeeSceneOpener : MonoBehaviour {
    [SerializeField] private string loadLevel;
    private void OnTriggerEnter(Collider other)
    {
       
            SceneManager.LoadScene(loadLevel);
            Debug.Log("collision");
        
    }

}
