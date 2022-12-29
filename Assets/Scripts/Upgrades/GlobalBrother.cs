using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBrother : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject priceText;
    public GameObject levelText;
    public GameObject cpsText;
    public TMPro.TMP_Text coinsText;
    public double currentCash;
    public static double brotherValue = 10;
    public static bool turnOffButton = false;
    public static int numberOfBrothers;
    public static double brotherPerSec;
    public static double CPS = 0.1;
    public AudioSource upgradeSound;

    void Update()
    {
        currentCash = GettingMoney._coins;
        priceText.GetComponent<Text>().text = "" + brotherValue.ToString("F0");
        levelText.GetComponent<Text>().text = numberOfBrothers.ToString();
        cpsText.GetComponent<Text>().text = CPS.ToString() + "/c";
        if (currentCash >= brotherValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < brotherValue)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
    public void BuyUpgrade()
    {
        GettingMoney._coins -= brotherValue;
        brotherValue *= 1.11;
        turnOffButton = true;
        brotherPerSec += CPS;
        numberOfBrothers += 1;
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
}
