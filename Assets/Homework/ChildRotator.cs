using UnityEngine;

class ChildRotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;

    void Update()
    {
        MeshRenderer[] meshRenderers = GetComponentsInChildren<MeshRenderer>();
        float angle = angularSpeed * Time.deltaTime;
        
        foreach (MeshRenderer renderer in meshRenderers) 
        {
            if (renderer.gameObject != gameObject)
            {
                Transform childT = renderer.GetComponent<Transform>();
                childT.Rotate(0, angle, 0);
            }
        }

        for (int i = 0; i < transform.childCount; i++)
        {
            Transform t = transform.GetChild(i);
        }
    }
}
