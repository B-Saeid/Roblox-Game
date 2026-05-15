using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LosingPlane : MonoBehaviour
{
    public GameObject loseImage;
    // Start is called before the first frame update
    void Start()
    {
        loseImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            loseImage.SetActive(true);
            // SceneManager.LoadScene("SampleScene");
            // print("Player fell down");
        }
    }
}
