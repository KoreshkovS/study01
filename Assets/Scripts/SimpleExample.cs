using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleExample : MonoBehaviour
{
    //скрипт: наш обʼєкт рухається за обраним обʼєктом

    [SerializeField] private Transform _objToFolow;

    private Vector3 _deltaPos;

    void Start()
    {
        _deltaPos = transform.position - _objToFolow.position;
    }

    void Update()
    {
        transform.position = _objToFolow.position + _deltaPos;
    }
}
