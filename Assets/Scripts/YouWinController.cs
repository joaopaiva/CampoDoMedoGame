using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinController : MonoBehaviour
{
    public AudioSource winnerSound;

    // Start is called before the first frame update
    void Start()
    {
        winnerSound = GetComponent<AudioSource>();
    }
     
     
    // called first
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        winnerSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
