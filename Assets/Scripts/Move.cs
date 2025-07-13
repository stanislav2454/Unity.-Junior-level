using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Vector3 _speed;

    private void Update() =>
        transform.Translate(_speed * Time.deltaTime);
}
