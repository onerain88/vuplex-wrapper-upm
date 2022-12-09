using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuplex.WebView;

public class VuplexWrapper : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        GameObject webviewGO = Instantiate(Resources.Load("CanvasWebViewPrefab")) as GameObject;
        webviewGO.transform.SetParent(transform);
        RectTransform rectTransform = webviewGO.GetComponent<RectTransform>();
        rectTransform.offsetMin = Vector2.zero;
        rectTransform.offsetMax = Vector2.zero;

        CanvasWebViewPrefab webViewPrefab = webviewGO.GetComponent<CanvasWebViewPrefab>();
        webViewPrefab.InitialUrl = "https://www.baidu.com";

        await webViewPrefab.WaitUntilInitialized();
    }
}
