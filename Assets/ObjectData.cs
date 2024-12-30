using System;
using UnityEngine;

[CreateAssetMenu(menuName = "EventPro/Object of Data")]
public class ObjectData : ScriptableObject
{
    public ObjectDataInfo objectDataInfos;
}

[Serializable]
public class ObjectDataInfo
{
    public int sunWant;
    public string name;
}