using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int coins = 0;
    public int requiredCoins = 5;
    public TextMeshProUGUI requiredCoinsText;
    public TextMeshProUGUI CurrentCoinsText;

    public GameObject winImage;

    // Start is called before the first frame update
    void Start()
    {
        winImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentCoinsText.text = coins.ToString();
        requiredCoinsText.text = requiredCoins.ToString();
        if (coins >= requiredCoins)
        {
            winImage.SetActive(true);
        }
    }

    public void ChangeScene(String sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
