using UnityEngine;

class ClickExploder : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay( mousePos );

        
    }
}
