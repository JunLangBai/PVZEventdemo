using UnityEngine;
using UnityEngine.UI;

public class SunText : MonoBehaviour
{
    public Text text;
    public Text sunwant;

    private void Awake()
    {
        text.text = "";
        sunwant.text = "";
    }

    private void OnEnable()
    {
        EventSystem.Plant += UpdateText;
        EventSystem.Plantname += UpdateTextToSunWant;
    }

    private void OnDisable()
    {
        EventSystem.Plant -= UpdateText;
        EventSystem.Plantname -= UpdateTextToSunWant;
    }

    public void UpdateText(int sun)
    {
        if (GameControl.instance.sun >= sun) text.text ="花费了 " + sun + ",当前阳光=" + (GameControl.instance.sun - sun);
        else
        {
            text.text = "没有" + sun + "阳光说你麻痹,当前阳光=" + GameControl.instance.sun;
        }
    }

    public void UpdateTextToSunWant(string sunswant)
    {
        sunwant.text = sunswant;
    }
    
}