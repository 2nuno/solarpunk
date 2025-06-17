using UnityEngine;

public class VirtualCameraFollower : MonoBehaviour
{
    public Transform player;         // Assign player transform
    public Vector3 worldPositionOffset;  // Offset in world space
    public Vector3 rotationOffset;   // Euler rotation offset

    void LateUpdate()
    {
        if (player != null)
        {
            // Use world-space offset: no rotation applied to offset
            transform.position = player.position + worldPositionOffset;

            // Copy rotation plus optional offset
            transform.rotation = player.rotation * Quaternion.Euler(rotationOffset);
        }
    }
}
