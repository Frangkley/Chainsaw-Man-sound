using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class 음성공유 : MonoBehaviour
{
	public void 클릭()
    {
		StartCoroutine(TakeScreenshotAndShare());
	}
	private IEnumerator TakeScreenshotAndShare()
	{
		yield return new WaitForEndOfFrame();

		Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
		ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
		ss.Apply();

		string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
		File.WriteAllBytes(filePath, ss.EncodeToPNG());

		// To avoid memory leaks
		Destroy(ss);

		new NativeShare().AddFile(filePath)
			.SetSubject("Subject goes here").SetText("Hello world!").SetUrl("https://github.com/yasirkula/UnityNativeShare")
			.SetCallback((result, shareTarget) => Debug.Log("Share result: " + result + ", selected app: " + shareTarget))
			.Share();

		// Share on WhatsApp only, if installed (Android only)
		//if( NativeShare.TargetExists( "com.whatsapp" ) )
		//	new NativeShare().AddFile( filePath ).AddTarget( "com.whatsapp" ).Share();
	}
	public TextAsset 음성;
	public void 음성공유하기()
	{
		string path = System.IO.Path.Combine(Application.temporaryCachePath, "video.mp3");
		System.IO.File.WriteAllBytes(path, 음성.bytes);

		new NativeShare().AddFile(path).Share();
	}
}
