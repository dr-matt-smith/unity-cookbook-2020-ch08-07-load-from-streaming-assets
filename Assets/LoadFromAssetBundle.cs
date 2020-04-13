using System;
using UnityEngine;
using System.IO;

public class LoadFromAssetBundle : MonoBehaviour
{
    public String assetBundleName = "cubered";
    public String prefabName = "CubeRed";
    
    void Start()
    {
        var myLoadedAssetBundle 
            = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, assetBundleName));
        if (myLoadedAssetBundle == null) {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }
        
        // create and instantiate prefab - red Cube
        var prefab = myLoadedAssetBundle.LoadAsset<GameObject>(prefabName);
        Instantiate(prefab);
    }
}