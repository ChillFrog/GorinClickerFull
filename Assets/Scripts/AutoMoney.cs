using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AutoMoney : MonoBehaviour
{
    public bool CreatingMoney = false;
    public static double MoneyIncrease;
    public GameObject GPS;
    public double InternalIncrease;
    [SerializeField] private TMP_Text _coinsText;

    private void Start()
    {
        Load();
    }
    void Update()
    {
        Save();
        MoneyIncrease = GlobalChair.chairPerSec + GlobalFreezer.freezerPerSec + GlobalBrother.brotherPerSec + GlobalFanta.fantasPerSec + GlobalCake.cakePerSec + GlobalPizza.pizzasPerSec + GlobalBanana.bananaPerSec ;
        InternalIncrease = MoneyIncrease;
        GPS.GetComponent<Text>().text = MoneyIncrease.ToString("F1") + "/с";
        if (CreatingMoney == false)
        {
            CreatingMoney = true;
            _coinsText.text = GettingMoney._coins.ToString("F0");
            if (GettingMoney._coins >= 1000)
                _coinsText.text = (GettingMoney._coins / 1000).ToString("F1") + " тыс";
            if (GettingMoney._coins >= 1000000)
                _coinsText.text = (GettingMoney._coins / 1000000).ToString("F1") + " мил";
            if (GettingMoney._coins >= 1000000000)
                _coinsText.text = (GettingMoney._coins / 1000000000).ToString("F1") + " млрд";
            if (GettingMoney._coins >= 1000000000000)
                _coinsText.text = (GettingMoney._coins / 1000000000000).ToString("F1") + " трлн";
            GettingMoney._coins += InternalIncrease * Time.deltaTime;
            CreatingMoney = false;
        }
    }
    public void Load()
    {
        GettingMoney._coins = PlayerPrefsX.GetDouble("coins");
        GettingMoney._coinsMultiplier = PlayerPrefsX.GetDouble("coinsMultiplier");

        Upgrades.BananaUpgradeValue = double.Parse(PlayerPrefs.GetString("bananaClickValue"));
        GlobalBanana.bananaValue = double.Parse(PlayerPrefs.GetString("bananasValue"));
        GlobalBanana.bananaPerSec = double.Parse(PlayerPrefs.GetString("bananasPerSec", "0"));
        GlobalBanana.numberOfBananas = PlayerPrefs.GetInt("numberOfBananas", 0);

        Upgrades.PizzaUpgradeValue = double.Parse(PlayerPrefs.GetString("pizzaClickValue"));
        GlobalPizza.pizzaValue = double.Parse(PlayerPrefs.GetString("pizzaValue"));
        GlobalPizza.pizzasPerSec = double.Parse(PlayerPrefs.GetString("pizzasPerSec", "0"));
        GlobalPizza.numberOfPizzas = PlayerPrefs.GetInt("numberOfPizzas", 0);

        Upgrades.CakeUpgradeValue = double.Parse(PlayerPrefs.GetString("cakeClickValue"));
        GlobalCake.cakeValue = double.Parse(PlayerPrefs.GetString("cakeValue"));
        GlobalCake.cakePerSec = double.Parse(PlayerPrefs.GetString("cakePerSec", "0"));
        GlobalCake.numberOfCakes = PlayerPrefs.GetInt("numberOfCakes", 0);

        Upgrades.FantaUpgradeValue = double.Parse(PlayerPrefs.GetString("fantaClickValue"));
        GlobalFanta.fantaValue = double.Parse(PlayerPrefs.GetString("fantaValue"));
        GlobalFanta.fantasPerSec = double.Parse(PlayerPrefs.GetString("fantasPerSec", "0"));
        GlobalFanta.numberOfFantas = PlayerPrefs.GetInt("numberOfFantas", 0);

        Upgrades.FreezerUpgradeValue = double.Parse(PlayerPrefs.GetString("freezerClickValue"));
        GlobalFreezer.freezerValue = double.Parse(PlayerPrefs.GetString("freezerValue"));
        GlobalFreezer.freezerPerSec = double.Parse(PlayerPrefs.GetString("freezerPerSec","0"));
        GlobalFreezer.numberOfFreezers = PlayerPrefs.GetInt("numberOfFreezers",0);

        Upgrades.ChairUpgradeValue = double.Parse(PlayerPrefs.GetString("chairClickValue"));
        GlobalChair.chairValue = double.Parse(PlayerPrefs.GetString("chairValue"));
        GlobalChair.chairPerSec = double.Parse(PlayerPrefs.GetString("chairPerSec","0"));
        GlobalChair.numberOfChairs = PlayerPrefs.GetInt("numberOfChairs",0);

        Upgrades.BrotherUpgradeValue = double.Parse(PlayerPrefs.GetString("brotherClickValue"));
        GlobalBrother.brotherValue = double.Parse(PlayerPrefs.GetString("brotherValue"));
        GlobalBrother.brotherPerSec = double.Parse(PlayerPrefs.GetString("brotherPerSec","0"));
        GlobalBrother.numberOfBrothers = PlayerPrefs.GetInt("numberOfBrothers",0);
    }
    public static void Save()
    {
        PlayerPrefsX.SetDouble("coins", GettingMoney._coins);
        PlayerPrefsX.SetDouble("coinsMultiplier", GettingMoney._coinsMultiplier);

        PlayerPrefs.SetString("brotherClickValue", Upgrades.BrotherUpgradeValue.ToString());
        PlayerPrefs.SetString("freezerValue", GlobalFreezer.freezerValue.ToString());
        PlayerPrefs.SetString("freezerPerSec", GlobalFreezer.freezerPerSec.ToString());
        PlayerPrefs.SetString("brotherValue", GlobalBrother.brotherValue.ToString());


        PlayerPrefs.SetString("fantaValue", GlobalFanta.fantaValue.ToString());
        PlayerPrefs.SetString("fantasPerSec", GlobalFanta.fantasPerSec.ToString());
        PlayerPrefs.SetString("chairValue", GlobalChair.chairValue.ToString());
        PlayerPrefs.SetString("chairPerSec", GlobalChair.chairPerSec.ToString());
        PlayerPrefs.SetString("brotherValue", GlobalBrother.brotherValue.ToString());
        PlayerPrefs.SetString("brotherPerSec", GlobalBrother.brotherPerSec.ToString());
        PlayerPrefs.SetInt("numberOfFreezers", GlobalFreezer.numberOfFreezers);
        PlayerPrefs.SetInt("numberOfFantas", GlobalFanta.numberOfFantas);
        PlayerPrefs.SetInt("numberOfChairs", GlobalChair.numberOfChairs);
        PlayerPrefs.SetInt("numberOfBrothers", GlobalBrother.numberOfBrothers);

    }
    public void DeletePrefs()
    {
        GettingMoney._coins = 0;
        GPS.GetComponent<Text>().text = "0";
        GettingMoney._coinsMultiplier = 1;

        Upgrades.BrotherUpgradeValue = 100;
        Upgrades.ChairUpgradeValue = 1000;
        Upgrades.FreezerUpgradeValue = 10000;
        Upgrades.FantaUpgradeValue = 100000;
        Upgrades.CakeUpgradeValue = 1000000;
        Upgrades.PizzaUpgradeValue = 10000000;
        Upgrades.BananaUpgradeValue = 100000000;

        GlobalBanana.bananaValue = 500;
        GlobalBanana.bananaPerSec = 0;
        GlobalBanana.numberOfBananas = 0;

        GlobalPizza.pizzaValue = 500;
        GlobalPizza.pizzasPerSec = 0;
        GlobalPizza.numberOfPizzas = 0;

        GlobalCake.cakeValue = 500;
        GlobalCake.cakePerSec = 0;
        GlobalCake.numberOfCakes = 0;

        GlobalFanta.fantaValue = 500;
        GlobalFanta.fantasPerSec = 0;
        GlobalFanta.numberOfFantas = 0;

        GlobalFreezer.freezerValue = 1100;
        GlobalFreezer.freezerPerSec = 0;
        GlobalFreezer.numberOfFreezers = 0;

        GlobalChair.chairValue = 100;
        GlobalChair.chairPerSec = 0;
        GlobalChair.numberOfChairs = 0;

        GlobalBrother.brotherValue = 10;
        GlobalBrother.brotherPerSec = 0;
        GlobalBrother.numberOfBrothers = 0;
    }
}
