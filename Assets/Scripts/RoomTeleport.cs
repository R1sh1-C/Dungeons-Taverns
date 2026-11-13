using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;


public class RoomTeleport : MonoBehaviour
{
    [Header("Teleport Settings")]
    [SerializeField] private Transform destination;

    [Header("Camera Settings")]
    [SerializeField] private CinemachineConfiner2D cameraConfiner;
    [SerializeField] private PolygonCollider2D destinationBoundary;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody2D playerRb = other.attachedRigidbody;

            if (playerRb != null)
            {
                // Move the player
                playerRb.position = destination.position;
                playerRb.linearVelocity = Vector2.zero;

                // Change the camera boundary
                cameraConfiner.BoundingShape2D = destinationBoundary;

                // Refresh the camera boundary
                cameraConfiner.InvalidateBoundingShapeCache();
            }
        }
    }
}


