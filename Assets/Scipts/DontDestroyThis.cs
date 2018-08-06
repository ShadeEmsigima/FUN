using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyThis : MonoBehaviour
{
    public static GameObject target;

    private void Awake()
    {
        Object.DontDestroyOnLoad(gameObject);
    }

}
