using UnityEngine;

public class OnPlant : MonoBehaviour
{
    private void OnEnable()
    {
        EventSystem.Plant += OnPlanted;
        EventSystem.Plantname += CatchName;
    }

    private void OnDisable()
    {
        EventSystem.Plant -= OnPlanted;
        EventSystem.Plantname -= CatchName;
    }

    public void OnPlanted(int nowSun)
    {
        if (GameControl.instance.sun >= nowSun) GameControl.instance.sun -= nowSun;
        else Debug.Log(nowSun);
    }

    public void CatchName(string name)
    {
        Debug.Log(name);
    }
}