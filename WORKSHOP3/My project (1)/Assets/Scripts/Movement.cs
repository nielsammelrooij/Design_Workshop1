using UnityEngine;

public class ClickToMove : MonoBehaviour
{
    private Vector3 _targetPosition;
    private Vector3 _velocity;

    public float floatHeight;
    public float smoothTime;
    public float speed;

    void OnClick()
    {
        Ray ray = Camera.main!.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            _targetPosition = new Vector3(hit.point.x, hit.point.y + floatHeight, hit.point.z);
        }
    }

    void Update()
    {
        if (_targetPosition != Vector3.zero)
        {
            transform.position = Vector3.SmoothDamp(transform.position, _targetPosition, ref _velocity, smoothTime, speed);
        }
    }
}
