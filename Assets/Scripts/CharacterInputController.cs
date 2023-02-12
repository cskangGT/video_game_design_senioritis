using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInputController : MonoBehaviour
{
    private float movementX;
    private float movementY;
    public bool enabled;
    
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x / 10;
        movementY = movementVector.y / 10;
    }

    private void FixedUpdate()
    {
        if (!enabled)
        {
            return;
        }
        
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        transform.Translate(movement);
    }
}