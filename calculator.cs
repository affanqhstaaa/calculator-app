class calculator
{
		static void Main(string[])
		{
			int a= 10;
			int b= 6;
			Console.Writeline("Hasil Penambahan: {0} + {1}",a,b,Penambahan(a,b));
			Console.Writeline("Hasil Pengurangan: {0} - {1}",a,b,Penambahan(a,b));
			
			Console.WriteLine("\ntekan sembarang key untuk keluar");
			Console.Readkey();
		}
		static int Penambahan(int a,int b)
		{
			return a + b;
		}
		static int Pengurangan(int a,int b)
		{
			return a - b;
		}
}