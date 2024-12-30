using UnityEngine;

public class Touchobject : MonoBehaviour
{
    public ObjectData data;

    private void OnMouseDown()
    {
        EventSystem.TriggerPlant(data.objectDataInfos.sunWant);
    }

    private void OnMouseExit()
    {
        EventSystem.CheakPlant(data.objectDataInfos.name);
    }
}