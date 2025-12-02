using UnityEngine;

public class SeedBoost : Item
{
    Player player;
    [field : SerializeField]public float newSpeed;
    public override void OnTriggerEnter2D(Player player)
    {
        player.SetMoveSpeed(newSpeed);
    }
}
