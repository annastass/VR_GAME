using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ParoplaneFly : MonoBehaviour
{
    public InputActionReference togglefly = null;
    public float MaxDrag;
    public float MaxVelocity;

    [Min(0)] public float MaxAngle;
    private float _dragValue;
    private Vector3 _velocity;

    private void Update()
    {
        if (togglefly.action.IsPressed())
        {
            gameObject.transform.localScale = Vector3.one * 14;
        }
        else
        {
            _dragValue = 0;
            _velocity = Vector3.zero;
            gameObject.transform.localScale = Vector3.zero;
            return;
        }

        float angle = Vector3.Angle(Vector3.up, transform.forward);

        if (angle <= MaxAngle)
        {
            _dragValue = (MaxAngle - angle) / MaxAngle;
            _velocity = transform.forward;
        }
        else
        {
            _velocity = Vector3.zero;
            _dragValue = 0;
        }
    }

    public float GetDragValue()
    {
        Debug.Log(_dragValue * MaxDrag);
        return _dragValue * MaxDrag;
    }

    public Vector3 GetVelocity()
    {
        _velocity.y = 0;
        return _velocity * MaxVelocity;
    }
}
