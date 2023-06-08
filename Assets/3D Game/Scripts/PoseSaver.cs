using UnityEngine;

public class PoseSaver : MonoBehaviour
{
    [SerializeField] string uniqueId;

    void Start()
    {
        // Betöltés

        if (PlayerPrefs.HasKey(uniqueId +" position x")) 
        {
            float x = PlayerPrefs.GetFloat(uniqueId + " position x");
            float z = PlayerPrefs.GetFloat(uniqueId + " position z");

            transform.position = new Vector3(x, 0, z); 
        }
    }

    void OnDestroy()
    {
        float x = transform.position.x;
        float z = transform.position.z;

        //  Mentés
        PlayerPrefs.SetFloat(uniqueId + " position x", x);
        PlayerPrefs.SetFloat(uniqueId + " position z", z);
    }

    void DeleteSaveData()
    {
        PlayerPrefs.DeleteKey(uniqueId + " position x");
        PlayerPrefs.DeleteKey(uniqueId + " position y");
    }
}
