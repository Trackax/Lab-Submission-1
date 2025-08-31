using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.ComponentModel;

public class ChessBoard : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        for (int y = 0; y <= 8; y++)
        {
            Vector3 startY = new Vector3(transform.position.x, transform.position.y + y * 1, transform.position.z);
            Vector3 endY = new Vector3(transform.position.x + 8 * 1, transform.position.y + y * 1, transform.position.z);
            Gizmos.DrawLine(startY, endY);
        }
        for (int x = 0; x <= 8; x++)
        {
            Vector3 startX = new Vector3(transform.position.x + x * 1, transform.position.y, transform.position.z);
            Vector3 endX = new Vector3(transform.position.x + x * 1, transform.position.y + 8 * 1, transform.position.z);
            Gizmos.DrawLine(startX, endX);
        }
    }
}
