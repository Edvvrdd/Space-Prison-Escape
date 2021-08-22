using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public LineRenderer LineRenderer;
    public Transform laserPosition;

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);
        LineRenderer.SetPosition(0, laserPosition.position);
        LineRenderer.SetPosition(1, hit.point);
    }
}
