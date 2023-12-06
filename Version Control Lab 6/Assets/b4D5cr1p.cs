using System;
using UnityEngine;

public class b4D5cr1p : MonoBehaviour

{
    [SerializeField] private float maxX; // Maximum movement range in X-axis.
    [SerializeField] private float maxY; // Maximum movement range in Y-axis.
    [SerializeField] private float maxZ; // Maximum movement range in Z-axis.
    private Vector3 newPosition; 
    private int moveCount = 0;
    private bool canMove = true; // Flag to control movement ability.
    private const int MaxMoves = 10; // Constant for maximum allowed moves.

    void Update()
    {
        // Check for mouse button click and if movement is allowed.
        if (Input.GetMouseButtonDown(0) && canMove)
        {
            MoveObject();
        }
    }

    // Function to move the object to a new random position within the defined ranges.
    private void MoveObject()
    {
        newPosition = new Vector3(
            UnityEngine.Random.Range(-maxX, maxX),
            UnityEngine.Random.Range(-maxY, maxY),
            UnityEngine.Random.Range(-maxZ, maxZ)
        );

        // Apply the new position to the object.
        transform.position = newPosition;
        Debug.Log("Object moved to: " + newPosition); // Log the new position.
        moveCount++; // Increment the move counter.

        // Check if the move count exceeds the maximum allowed moves.
        if (moveCount > MaxMoves)
        {
            canMove = false; // Disable further movement.
            Debug.LogWarning("Move limit reached. Can't move anymore.");
        }
    }

    // Public function to reset the movement ability and counter.
    public void ResetMovement()
    {
        moveCount = 0; // Reset the move counter.
        canMove = true; // Enable movement again.
        Debug.Log("Movement reset. You can move again."); // Log the reset status.
    }
}
