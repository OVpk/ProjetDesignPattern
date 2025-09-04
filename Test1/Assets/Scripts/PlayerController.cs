using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public GameObject player;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void Move(Vector2 direction)
    {
        player.transform.position = new Vector2(player.transform.position.x + direction.x, player.transform.position.y + direction.y);
    }
}
