using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BulletDirection : ScriptableObject
{
    [SerializeField] public Direction bulletDirection;
    [SerializeField] Vector3 direction;
    public enum Direction
    {
        Up, Down, Left, Right
    }

    public Vector3 GetBulletDirection()
    {

        return direction;
    }

    public void SetDirection(string bulletDirection)
    {
        switch (bulletDirection.ToLower())
        {
            case "up":
                direction = Vector2.up;
                break;
            case "down":
                direction = Vector2.down;
                break;
            case "left":
                direction = Vector2.left;
                break;
            case "right":
                direction = Vector2.right;
                break;
        }
    }
}
