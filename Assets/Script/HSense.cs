using UnityEngine;

public abstract class HSense : MonoBehaviour, IhsenseBehaviour
{

    public abstract void Initialized();
    public abstract void UpdateSense();

    protected HAspectType aType = HAspectType.ENEMY;

    // Use this for initialization
    void Start()
    {
        Initialized();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSense();
    }
}
