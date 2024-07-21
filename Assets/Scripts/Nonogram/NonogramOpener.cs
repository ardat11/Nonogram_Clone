using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class NonogramOpener : MonoBehaviour
{

    // Update is called once per frame
    private void OnMouseOver()
    {
        if (TouchManager.instance.GetIsMouseDown())
        {
            print("Basýldý:" + gameObject.name);
            BoxCollider2D collider = this.GetComponent<BoxCollider2D>();
            collider.enabled = false;
            ResRevealer result = GetComponent<ResRevealer>();
            result.Reveal();

            if(TouchManager.instance.GetTouchType() == 2)
            {
                BonusManager.instance.DecreaseBonus();
            }

        }
    }
}
