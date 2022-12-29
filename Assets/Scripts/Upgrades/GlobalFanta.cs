using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalFanta : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject priceText;
    public GameObject levelText;
    public GameObject cpsText;
    public TMPro.TMP_Text coinsText;
    public double currentCash;
    public static double fantaValue = 12000;
    public static bool turnOffButton = false;
    public static int numberOfFantas;
    public static double fantasPerSec;
    public static int CPS = 50;
    public AudioSource upgradeSound;

    void Update()
    {
        currentCash = GettingMoney._coins;
        priceText.GetComponent<Text>().text = "" + fantaValue.ToString("F0");
        levelText.GetComponent<Text>().text = numberOfFantas.ToString();
        cpsText.GetComponent<Text>().text = CPS.ToString() + "/c";
        if (currentCash >= fantaValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < fantaValue)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
    public void BuyUpgrade()
    {
        GettingMoney._coins -= fantaValue;
        fantaValue *= 1.10;
        turnOffButton = true;
        fantasPerSec += CPS;
        numberOfFantas += 1;
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
}
