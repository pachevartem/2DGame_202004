using UnityEngine;
using UnityEngine.SceneManagement;

namespace Advenced
{
    public class AdvancedCreateGameObejct: MonoBehaviour
    {

        public void CRERE1111111Object()
        {
            GameObject a = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube));
            a.transform.position = Vector3.up * 2;
            a.AddComponent<Rigidbody>();
        }

        public void My111123123123112ResetScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}