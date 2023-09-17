namespace TemplateMethodPattern
{
	internal class Tee : KoffeinhaltigesGetraenk
	{
		#region Internals
		protected override void Aufgiessen()
		{
			Console.WriteLine("Tee aufgiessen.");
		}

		protected override void ZutatenHinzufuegen()
		{
			Console.WriteLine("Zucker wird hinzugefügt.");
		}
		#endregion
	}
}