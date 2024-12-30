using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSun : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameControl.instance.UpSun();
    }
}
