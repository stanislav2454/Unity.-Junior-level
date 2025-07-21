using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [Header("Тест атрибутов")]
    [Space(10)]
    [SerializeField, Min(0)] private int _countMin;
    [SerializeField, Delayed] private int _countMax = 1;
    [Space(5)]
    [Tooltip("тестовое поле просмотра работы атрибута \"Tooltip\"")]
    [SerializeField, Range(1, 99)] private int _countBullets = 1;

    private int _amount;

    public int Amount => _amount;

    private void OnValidate()
    {
        if (_countMin >= _countMax)
            _countMin = _countMax - 1;
    }
}
