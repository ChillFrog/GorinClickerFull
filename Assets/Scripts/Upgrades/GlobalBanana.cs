using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBanana : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject priceText;
    public GameObject levelText;
    public TMPro.TMP_Text coinsText;
    public GameObject cpsText;
    public double currentCash;
    public static double bananaValue = 680000;
    public static bool turnOffButton = false;
    public static int numberOfBananas;
    public static int CPS = 1000;
    public static double bananaPerSec;
    public AudioSource upgradeSound;

    void Update()
    {
        currentCash = GettingMoney._coins;
        priceText.GetComponent<Text>().text = "" + bananaValue.ToString("F0");
        levelText.GetComponent<Text>().text = numberOfBananas.ToString();
        cpsText.GetComponent<Text>().text = CPS.ToString() + "/c";

        if (currentCash >= bananaValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < bananaValue)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
    public void BuyUpgrade()
    {
        GettingMoney._coins -= bananaValue;
        bananaValue *= 1.10;
        turnOffButton = true;
        bananaPerSec += CPS;
        numberOfBananas += 1;
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
}

