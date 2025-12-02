using UnityEngine;

public class SeedBoost : Item
{
    Player player;
    [field : SerializeField]public float newSpeed;
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        player.SetMoveSpeed(newSpeed);
    }
}
