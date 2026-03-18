using UnityEngine;

public class secondspeedscript : MonoBehaviour
{
    [SerializeField] private int _SpeedValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int GetSpeedValue()
    {
        _SpeedValue = 50;
        return _SpeedValue;
    }
}