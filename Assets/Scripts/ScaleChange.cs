using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _scale;

    void Update()
    {
        _scale.x = _scale.y = _scale.z = _speed;
        transform.localScale += _scale * Time.deltaTime;
    }
}
