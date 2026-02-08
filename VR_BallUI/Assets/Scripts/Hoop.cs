using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoop : MonoBehaviour
{
    public GameObject popEffectPrefab;

    void OnTriggerEnter(Collider collision)
    {
        if (transform.parent == null && collision.gameObject.GetComponent<Hoop>() == null)
        {
            PopBalloon();
        }
    }

    private void PopBalloon()
    {
        if (popEffectPrefab != null)
        {
            GameObject effect = Instantiate(popEffectPrefab, transform.position, transform.rotation);
            Destroy(effect, 1f);
        }
    }
}
