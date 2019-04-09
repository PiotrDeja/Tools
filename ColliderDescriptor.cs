using UnityEngine;

public enum ColliderType
{
    Stone,
    Flesh,
    Wood
}

public class ColliderDescriptor : MonoBehaviour
{
    public System.Action<Collider> triggerEntered;
    public System.Action<Collider> triggerExited;
    public ColliderType type;

    void OnTriggerEnter(Collider col)
    {
        if (triggerEntered != null) triggerEntered(col);      
    }

    void OnTriggerExit(Collider col)
    {
        if (triggerExited != null) triggerExited(col);     
    }
}
