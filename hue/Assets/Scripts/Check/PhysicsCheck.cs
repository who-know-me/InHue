using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCheck : MonoBehaviour
{

    [Header("¼ì²â²ÎÊý")]
    public Vector2 bottomOffset;
    public float checkRadius;
    public LayerMask groundlayer;

    [Header("×´Ì¬")]
    public bool isGround;

    private void Update()
    {
        check();
    }
    public void check()
    {
        isGround = Physics2D.OverlapCircle((Vector2)transform.position + bottomOffset, checkRadius, groundlayer);
    }
    private void OnDrawGizmosSelected()
    {
            Gizmos.DrawWireSphere((Vector2)transform.position + bottomOffset, checkRadius);
    }
}
