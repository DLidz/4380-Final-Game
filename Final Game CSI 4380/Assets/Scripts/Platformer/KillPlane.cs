using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlane : MonoBehaviour
{
    [SerializeField]
    SceneLoader sceneLoader;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.rigidbody.tag == "Player")
        {
            sceneLoader.LoadPlatformer();
        }
    }
}
