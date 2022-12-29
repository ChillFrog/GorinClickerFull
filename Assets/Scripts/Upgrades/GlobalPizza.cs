using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalPizza : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject priceText;
    public GameObject levelText;
    public GameObject cpsText;
    public TMPro.TMP_Text coinsText;
    public double currentCash;
    public static double pizzaValue = 144000;
    public static bool turnOffButton = false;
    public static int numberOfPizzas;
    public static double CPS = 200;
    public static double pizzasPerSec;
    public AudioSource upgradeSound;

    void Update()
    {
        currentCash = GettingMoney._coins;
        priceText.GetComponent<Text>().text = "" + pizzaValue.ToString("F0");
        levelText.GetComponent<Text>().text = numberOfPizzas.ToString();
        cpsText.GetComponent<Text>().text = CPS.ToString() + "/c";
        if (currentCash >= pizzaValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < pizzaValue)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
    public void BuyUpgrade()
    {
        GettingMoney._coins -= pizzaValue;
        pizzaValue *= 1.10;
        turnOffButton = true;
        pizzasPerSec += CPS;
        numberOfPizzas += 1;
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
}
