using System.Collections;
using System.Collections.Generic;
using UnityEditor;
#if UNITY_EDITOR
using UnityEngine;
#endif

public class Gate : MonoBehaviour
{
    public float MaxDepth;
    public Gate NextGate;

    private void Update()
    {
        if (transform.position.y - MaxDepth > Player.MainPlayer.transform.position.y)
        {
            Player.MainPlayer.Return();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.ToLower() != "player") return;

        NextGate?.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Handles.color = Color.red;
        Handles.DrawWireArc(transform.position + Vector3.down * MaxDepth, Vector3.up, Vector3.forward, 360, 0.75f);
    }
#endif
}
