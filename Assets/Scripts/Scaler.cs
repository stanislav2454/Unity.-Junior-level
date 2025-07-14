using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
        => transform.localScale += Vector3.one * _speed * Time.deltaTime;
}
