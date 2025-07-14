using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    void Update() =>
     transform.RotateAround(transform.position, transform.up, _speed * Time.deltaTime);
}
