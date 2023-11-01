using UnityEngine;

public class RoutePoint : MonoBehaviour
{
    public RoutePoint nextPoint;

    public GameObject model;

    public bool isActiveForPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            if (isActiveForPlayer) 
            {
                isActiveForPlayer = false;
                model.SetActive(false);

                if (nextPoint != null)
                {
                    nextPoint.isActiveForPlayer = true;
                    nextPoint.model.SetActive(true);
                }
            }
        }
    }

}
