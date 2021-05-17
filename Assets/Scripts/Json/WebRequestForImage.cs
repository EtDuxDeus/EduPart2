using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Tools
{
    public class WebRequestForImage : MonoBehaviour
    {
        [SerializeField] private string url;
        Image mat;

        void Start()
        {
            StartCoroutine(SendRequestForImage());
            mat = GetComponent<Image>();

        }


        private IEnumerator SendRequestForImage()
        {
            UnityWebRequest request = UnityWebRequestTexture.GetTexture(url);
            yield return request.SendWebRequest();
            var image = DownloadHandlerTexture.GetContent(request);
            Debug.Log(image);
            mat.sprite = Sprite.Create(image, new Rect(0.0f, 0.0f, image.width, image.height), new Vector2(0.5f, 0.5f), 100.0f);

        }
    }
}
