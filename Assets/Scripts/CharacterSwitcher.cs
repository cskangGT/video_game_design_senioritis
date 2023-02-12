using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterSwitcher : MonoBehaviour
{
    public CharacterInputController[] ControllableCharacters = {};
    
    public CameraController thirdPersonCamera;

    public string CameraPositionMarkerName = "CamPos";

    protected int nextCharacterIndex = 1;
    
    // Start is called before the first frame update
    void Start()
    {

    }
    
    protected void disableAllCharacters() {

        foreach (CharacterInputController c in ControllableCharacters)
        {
            c.enabled = false;
        }
            
    }
    
    protected void setCharacter(int charIndex) {

        disableAllCharacters();

        if (charIndex < 0)
            charIndex = 0;

        if (charIndex >= ControllableCharacters.Length)
            charIndex = ControllableCharacters.Length - 1;

        ControllableCharacters[charIndex].enabled = true;

        thirdPersonCamera.cameraPosition = ControllableCharacters[charIndex].transform.Find(CameraPositionMarkerName).position;
        thirdPersonCamera.player = ControllableCharacters[charIndex].transform;
    }
    
    protected void incrementCharacterIndex() {
        nextCharacterIndex++;

        if (nextCharacterIndex < 0 || nextCharacterIndex >= ControllableCharacters.Length)
            nextCharacterIndex = 0;
    }

    protected void toggleCharacter() {
        setCharacter(nextCharacterIndex);

        incrementCharacterIndex();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            Debug.Log("Character toggled");
            toggleCharacter();
            Debug.Log("next character index: " + nextCharacterIndex);

        }
    }
}
