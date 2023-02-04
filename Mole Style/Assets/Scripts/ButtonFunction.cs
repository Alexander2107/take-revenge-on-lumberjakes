using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunction : MonoBehaviour
{
    [SerializeField] private Transform root;
    public Vector2 startpos;
    public Vector2 endpos;
    public float step;
    private float progress;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        root.transform.position = Vector2.Lerp(startpos, endpos, progress);
        progress *= step;
    }
        
}