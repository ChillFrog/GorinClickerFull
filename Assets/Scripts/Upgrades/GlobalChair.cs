using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalChair : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject priceText;
    public GameObject levelText;
    public GameObject cpsText;
    public TMPro.TMP_Text coinsText;
    public double currentCash;
    public static double chairValue = 100;
    public static bool turnOffButton = false;
    public static int numberOfChairs;
    public static double chairPerSec;
    public static double CPS = 1;
    public AudioSource upgradeSound;

    void Update()
    {
        currentCash = GettingMoney._coins;
        priceText.GetComponent<Text>().text = "" + chairValue.ToString("F0");
        levelText.GetComponent<Text>().text = numberOfChairs.ToString();
        cpsText.GetComponent<Text>().text = CPS.ToString() + "/c";
        if (currentCash >= chairValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < chairValue)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
    public void BuyUpgrade()
    {
        GettingMoney._coins -= chairValue;
        chairValue *= 1.11;
        turnOffButton = true;
        chairPerSec += CPS;
        numberOfChairs += 1;
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
}
