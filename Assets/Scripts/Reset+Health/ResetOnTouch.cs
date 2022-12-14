using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnTouch : MonoBehaviour
{
    [SerializeField] List<string> damagingTags;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(damagingTags.Contains(collision.collider.tag))
        {
            LevelManager.instance.Death();
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (damagingTags.Contains(collision.tag))
        {
            LevelManager.instance.Death();
        }
    }
}
