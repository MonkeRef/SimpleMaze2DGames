using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    [SerializeField] private int nextSceneLoad;

    private void OnTriggerEnter2D (Collider2D collision){ 
        if (collision.gameObject.CompareTag("User")) {
            SceneManager.LoadScene(nextSceneLoad);
        }
    }
}
