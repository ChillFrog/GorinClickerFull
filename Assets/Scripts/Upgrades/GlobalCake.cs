using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCake : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject priceText;
    public GameObject levelText;
    public GameObject cpsText;
    public TMPro.TMP_Text coinsText;
    public double currentCash;
    public static double cakeValue = 48000;
    public static bool turnOffButton = false;
    public static int numberOfCakes;
    public static int CPS = 25;
    public static double cakePerSec;
    public AudioSource upgradeSound;

    void Update()
    {
        currentCash = GettingMoney._coins;
        priceText.GetComponent<Text>().text = "" + cakeValue.ToString("F0");
        levelText.GetComponent<Text>().text = numberOfCakes.ToString();
        cpsText.GetComponent<Text>().text = CPS.ToString() + "/c";
        if (currentCash >= cakeValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < cakeValue)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
    public void BuyUpgrade()
    {
        GettingMoney._coins -= cakeValue;
        cakeValue *= 1.11;
        turnOffButton = true;
        cakePerSec += CPS;
        numberOfCakes += 1;
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
}