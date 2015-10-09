using System;

namespace GarbageCollectSample
{

	class Garbage
	{
		float[] a = new float[10000];
	}



	class MainClass
	{
		public static void Main (string[] args)
		{
			MainClass.creatingGarbage (10000);
			long beforeCollect = GC.GetTotalMemory (false);
			Console.WriteLine ("Memory used before collection: {0}",beforeCollect);
			GC.Collect();
			long afterCollect = GC.GetTotalMemory (false);
			Console.WriteLine ("Memory used after full collection: {0}",afterCollect);
			Console.WriteLine ("Memory freed after Garbage Collection: {0}",beforeCollect-afterCollect);
		}

		static void creatingGarbage(int size)
		{
			for (int i = 0; i < size; i++)
			{
				Garbage gb = new Garbage ();
			}
		}


	}
}
