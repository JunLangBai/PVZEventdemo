using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public int sun;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    public void UpSun()
    {
        sun += 25;
        Debug.Log("Up Sun");
    }
}