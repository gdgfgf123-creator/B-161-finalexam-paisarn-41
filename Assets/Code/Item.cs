using UnityEngine;

public abstract class Item : MonoBehaviour
{
    Player player;
    
    public abstract void OnTriggerEnter2D(Collider2D collision);
    
}
