using System;
using System.Net;
using HtmlAgilityPack;
using System.IO;

namespace RandomPicture
{
	public class RandPic
	{
		static readonly string URL = "https://picsum.photos/";

		public static string Download(string path, int width, int height)
		{
			string url = URL + width + "/" + height;
			string randomFileName = Path.GetRandomFileName() + ".png";
			using (WebClient client = new WebClient())
			{
				client.DownloadFile(url,path + randomFileName);
			}

			return randomFileName;
		}
	}
}
