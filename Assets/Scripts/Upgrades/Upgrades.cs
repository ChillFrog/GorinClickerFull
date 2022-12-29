using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public GameObject BrotherUpgrade;
    public GameObject ChairUpgrade;
    public GameObject FreezerUpgrade;
    public GameObject FantaUpgrade;
    public GameObject CakeUpgrade;
    public GameObject PizzaUpgrade;
    public GameObject BananaUpgrade;

    public TMPro.TMP_Text coinsText;

    public static double BrotherUpgradeValue = 100;
    public static double ChairUpgradeValue = 1000;
    public static double FreezerUpgradeValue = 10000;
    public static double FantaUpgradeValue = 100000;
    public static double CakeUpgradeValue = 1000000;
    public static double PizzaUpgradeValue = 10000000;
    public static double BananaUpgradeValue = 100000000;

    public double currentCash;

    void Update()
    {
        currentCash = GettingMoney._coins;

            if (currentCash >= BrotherUpgradeValue )
            {
                BrotherUpgrade.SetActive(true);
            }
            else if (currentCash < BrotherUpgradeValue)
            {
                BrotherUpgrade.SetActive(false);
            }
            if (currentCash >= ChairUpgradeValue)
            {
                ChairUpgrade.SetActive(true);
            }
            else if (currentCash < ChairUpgradeValue)
            {
                ChairUpgrade.SetActive(false);
            }
            if (currentCash >= FreezerUpgradeValue)
            {
                FreezerUpgrade.SetActive(true);
            }
            else if (currentCash < FreezerUpgradeValue)
            {
                FreezerUpgrade.SetActive(false);
            }
            if (currentCash >= FantaUpgradeValue)
            {
                FantaUpgrade.SetActive(true);
            }
            else if (currentCash < FantaUpgradeValue)
            {
                FantaUpgrade.SetActive(false);
            }
            if (currentCash >= CakeUpgradeValue)
            {
                CakeUpgrade.SetActive(true);
            }
            else if (currentCash < CakeUpgradeValue)
            {
                CakeUpgrade.SetActive(false);
            }
            if (currentCash >= PizzaUpgradeValue)
            {
                PizzaUpgrade.SetActive(true);
            }
            else if (currentCash < PizzaUpgradeValue)
            {
                PizzaUpgrade.SetActive(false);
            }
            if (currentCash >= BananaUpgradeValue )
            {
                BananaUpgrade.SetActive(true);
            }
            else if (currentCash < BananaUpgradeValue)
            {
                BananaUpgrade.SetActive(false);
            }
    }
    public void BuyBrotherUpgrade()
    {
        GettingMoney._coins -= BrotherUpgradeValue;
        BrotherUpgradeValue *= 10;
        GettingMoney._coinsMultiplier += 1;
        PlayerPrefs.SetString("brotherClickValue", BrotherUpgradeValue.ToString());
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
    public void BuyChairUpgrade()
    {
        GettingMoney._coins -= ChairUpgradeValue;
        ChairUpgradeValue *= 10;
        GettingMoney._coinsMultiplier += 1;
        PlayerPrefs.SetString("ChairClickValue", ChairUpgradeValue.ToString());
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
    public void BuyFreezerUpgrade()
    {
        GettingMoney._coins -= FreezerUpgradeValue;
        FreezerUpgradeValue *= 10;
        GettingMoney._coinsMultiplier += 1;
        PlayerPrefs.SetString("FreezerClickValue", FreezerUpgradeValue.ToString());
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
    public void BuyFantaUpgrade()
    {
        GettingMoney._coins -= FantaUpgradeValue;
        FantaUpgradeValue *= 10;
        GettingMoney._coinsMultiplier += 1;
        PlayerPrefs.SetString("FantaClickValue", FantaUpgradeValue.ToString());
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
    public void BuyCakeUpgrade()
    {
        GettingMoney._coins -= CakeUpgradeValue;
        CakeUpgradeValue *= 10;
        GettingMoney._coinsMultiplier += 1;
        PlayerPrefs.SetString("CakeClickValue", CakeUpgradeValue.ToString());
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
    public void BuyPizzaUpgrade()
    {
        GettingMoney._coins -= PizzaUpgradeValue;
        PizzaUpgradeValue *= 10;
        GettingMoney._coinsMultiplier += 1;
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
    public void BuyBananaUpgrade()
    {
        GettingMoney._coins -= BananaUpgradeValue;
        BananaUpgradeValue *= 10;
        GettingMoney._coinsMultiplier += 1;
        PlayerPrefs.SetString("BananaClickValue", BananaUpgradeValue.ToString());
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        coinsText.text = GettingMoney._coins.ToString("F0");
    }
}
