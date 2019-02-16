using UnityEngine;

public class HPerspective : HSense {
    public Transform player;
    float viewDistance;
    float fieldOfView; 
    public Transform rayOrigin;
    Animator anim;
    public override void Initialized()
    {
        anim = GetComponent<Animator>();
        viewDistance = 70;
        fieldOfView = 130;

    }
    public override void UpdateSense()
    {
        if (!player)
            return;
        Vector3 dir = (player.position - rayOrigin.position).normalized;
        if (Vector3.Angle(dir, rayOrigin.forward) < fieldOfView / 2f)
        {
            Debug.DrawRay(rayOrigin.position, dir * viewDistance, Color.red);
            RaycastHit hitInfo;
            if (Physics.Raycast(rayOrigin.position, dir, out hitInfo, viewDistance))
            {
                HAspect aspect = hitInfo.transform.GetComponent<HAspect>();
                
                if (aspect != null)
                {
                    if (aspect.aType == aType)
                    {
                        anim.SetBool("isVisible", true);
                    }
                    else
                        anim.SetBool("isVisible", false);
                }
            }
        }
       
    }

    
}
