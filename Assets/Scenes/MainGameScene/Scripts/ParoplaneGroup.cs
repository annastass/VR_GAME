using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ParoplaneGroup : MonoBehaviour
{
    public Rigidbody RB;
    public List<ParoplaneFly> Paroplanes;

    private void Update()
    {
        float drag_val = Paroplanes.Select(x => x.GetDragValue()).Sum();

        var velocity_vals = Paroplanes.Select(x => x.GetVelocity());
        Vector3 total_velocity = Vector3.zero;

        foreach (var vel in velocity_vals) total_velocity += vel;
        total_velocity.y = RB.velocity.y;

        RB.drag = drag_val;
        RB.velocity = total_velocity;
    }
}
