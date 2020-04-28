using System.Collections;
using UnityEngine;

namespace Advenced
{
    public class GetWWWPictures: MonoBehaviour
    {
         string url = "https://sun9-49.userapi.com/c206520/v206520719/eed70/rfNvuC2k63A.jpg";
    
        IEnumerator Start()
        {
            using (WWW www = new WWW(url))
            {
                yield return www;
                Renderer renderer = GetComponent<Renderer>();
                renderer.material.mainTexture = www.texture;
            }
        }
    }
}