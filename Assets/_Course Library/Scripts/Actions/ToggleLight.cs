using UnityEngine;

/// <summary>
/// Toggles a light
/// </summary>
public class ToggleLight : MonoBehaviour
{
    [Tooltip("Controls the state of the light")]
    public bool isOn = false;
    [SerializeField] private Light currentLight;

    private void Start()
    {
        currentLight.enabled = isOn;
    }

    public void TurnOn()
    {
        isOn = true;
        currentLight.enabled = isOn;
    }

    public void TurnOff()
    {
        isOn = false;
        currentLight.enabled = isOn;
    }

    public void Flip()
    {
        isOn = !isOn;
        currentLight.enabled = isOn;
    }

    private void OnValidate()
    {
        if (currentLight)
            currentLight.enabled = isOn;
    }
}
