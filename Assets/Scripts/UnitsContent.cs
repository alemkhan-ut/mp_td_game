using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsContent : MonoBehaviour
{
    public static UnitsContent Instance;

    private void Awake()
    {
        Instance = this;
    }
}
