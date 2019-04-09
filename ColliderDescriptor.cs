using UnityEngine;

public enum ColliderType
{
    Stone,
    Flesh,
    Wood
}

public class ColliderDescriptor : MonoBehaviour
{
    public System.Action<Collider, ColliderType> triggerEntered;
    public System.Action<Collider ColliderType> triggerExited;
    public ColliderType type;

    void OnTriggerEnter(Collider col)
    {
        if (triggerEntered != null) triggerEntered(col, type);      
    }

    void OnTriggerExit(Collider col)
    {
        if (triggerExited != null) triggerExited(col, type);     
    }
}
