using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Text;

namespace Tools
{
    public class WebRequest : MonoBehaviour
    {
        [SerializeField] private string _url;


        private void Start()
        {
            StartCoroutine(SendRequest());
            StartCoroutine(SendPost());
        }


        private IEnumerator SendRequest()
        {
            UnityWebRequest request = UnityWebRequest.Get(_url);
            yield return request.SendWebRequest();

            Debug.Log(request.downloadHandler.text);
        }


        private IEnumerator SendPost()
        {
            WWWForm dataform = new WWWForm();

            MyClassForJSon post = new MyClassForJSon();
            FillTheFieldsOfEntity(post);

            string json = JsonUtility.ToJson(post);

            UnityWebRequest request = UnityWebRequest.Post(_url, dataform);

            byte[] postByte = Encoding.UTF8.GetBytes(json);

            UploadHandler uploadhandler = new UploadHandlerRaw(postByte);

            request.uploadHandler = uploadhandler;

            request.SetRequestHeader("Content-Type", "application/json; charset=UTF-8");

            yield return request.SendWebRequest();

            MyClassForJSon postFromServer = JsonUtility.FromJson<MyClassForJSon>(request.downloadHandler.text);

            Debug.Log(postFromServer);
        }


        private void FillTheFieldsOfEntity(MyClassForJSon post)
        {
            post.myName = "Mikey";
            post.myMoney = 888888;
            post.myRank = 0;
        }

    }
}
