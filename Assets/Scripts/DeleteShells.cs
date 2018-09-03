using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteShells : MonoBehaviour
{
    public GameObject shell;

    void Start()
    {
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag=="Enemy")
        {
            Destroy(shell);
        }
    }
}
