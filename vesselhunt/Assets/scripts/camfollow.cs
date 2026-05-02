//Script for main camera to follow Shader

using TMPro;
using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;
    public Vector2 offset; // Use Vector2 for X and Y offsets

    void LateUpdate()
    {
        // Create a target position that keeps the camera's original Z depth
        Vector3 targetPosition = new Vector3(target.position.x + offset.x, target.position.y + offset.y, transform.position.z);

        // Smoothly move the camera
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);
    }
}
