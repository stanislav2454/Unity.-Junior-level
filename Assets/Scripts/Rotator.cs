using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private Vector3 v;

    private void Update() =>
      //transform.Rotate(v.x, v.y, v.z); // = // transform.Rotate(v);
      // transform.RotateAround(transform.position, transform.up, _speed * Time.deltaTime);
      transform.rotation *= Quaternion.Euler(v.x, v.y, v.z);
}
