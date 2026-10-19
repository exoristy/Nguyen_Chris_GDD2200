
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField] private float dayLengthInSeconds = 120f;

    void Update()
    {
        float rotationSpeed = 360f / dayLengthInSeconds;

        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
