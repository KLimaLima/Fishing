using UnityEngine;

public class RotLine : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] Transform startPoint;
    [SerializeField] Transform endPoint;

    void Update()
    {
        var positions = new Vector3[] { startPoint.position, endPoint.position, };
        lineRenderer?.SetPositions(positions);
    }
}