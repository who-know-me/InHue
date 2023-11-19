using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Colour : MonoBehaviour
{
    public Inputcolour inputcolour;

    public SpriteRenderer spriteRenderer;

    private Color skyblue = new Color(0,255, 255, 255);
    private Color darkblue = new Color(0, 0, 255, 255);
    private Color green = new Color(0, 255,  0, 255);
    private Color yellow = new Color(255, 255, 0, 255);
    private Color red = new Color(255, 0, 0, 255);
    private Color pink = new Color(255, 0, 255, 255);

    private void Awake()
    {
        inputcolour=new Inputcolour();
        spriteRenderer = GetComponent<SpriteRenderer>();

        inputcolour.changeColours.cskyblue.started += Skyblue;
        inputcolour.changeColours.cgreen.started += Green;
        inputcolour.changeColours.cred.started += Red;
        inputcolour.changeColours.cdarkblue.started += Darkblue;
        inputcolour.changeColours.cyellow.started += Yellow;
        inputcolour.changeColours.cpink.started += Pink;

    }
    private void OnEnable()
    {
        inputcolour.Enable();
    }
    private void OnDisable()
    {
        inputcolour.Disable();
    }
    private void Skyblue(InputAction.CallbackContext obj)
    {
        spriteRenderer.color = skyblue;
    }
    private void Green(InputAction.CallbackContext obj)
    {
        spriteRenderer.color = green;
    }
    private void Red(InputAction.CallbackContext obj)
    {
        spriteRenderer.color = red;
    }
    private void Darkblue(InputAction.CallbackContext obj)
    {
        spriteRenderer.color = darkblue;
    }
    private void Yellow(InputAction.CallbackContext obj)
    {
        spriteRenderer.color = yellow;
    }
    private void Pink(InputAction.CallbackContext obj)
    {
        spriteRenderer.color = pink;
    }
}
