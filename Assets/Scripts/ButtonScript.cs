using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    private Transform memoriceField;

    [SerializeField]
    private GameObject membtn;

    void Awake()
    {
        for (int i = 0; i < 9; i++)
        {
            GameObject button = Instantiate(membtn);
            button.name = "" + i;
            button.transform.SetParent(memoriceField, false);
        }
    }
}
