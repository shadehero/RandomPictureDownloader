using System;

namespace RandomPicture
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Title = "Random Picture Downloader by Doctor Bogdan";

			Console.WriteLine("Download Random Picture");

			Console.Write("Set Width : ");
			int width = Convert.ToInt32(Console.ReadLine());

			Console.Write("Set Height : ");
			int height = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Starting Download Random Image");
			string name = RandPic.Download("Images/", width, height);
			Console.WriteLine("Download File {0} Done!", name);
			Console.ReadKey();
		}
	}
}
