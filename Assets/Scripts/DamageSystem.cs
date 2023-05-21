﻿using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    [Header("血量資料")]
    public DataHealth data;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // print(collision.gameObject);
        if (collision.gameObject.name.Contains("武器"))
        {
            print("被武器打到~");
        }
    }
}