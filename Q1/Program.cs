using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			FileManager saver=new FileManager();
			saver.Save("txt","words");
		}
	}
	class FileManager
	{
		public void Save(string txt, string words)
		{
		
		}
	}

}
