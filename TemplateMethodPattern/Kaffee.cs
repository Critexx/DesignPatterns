namespace TemplateMethodPattern
{
	internal class Kaffee : KoffeinhaltigesGetraenk
	{
		#region Internals
		protected override void Aufgiessen()
		{
			Console.WriteLine("Kaffee aufgiessen.");
		}

		protected override void ZutatenHinzufuegen()
		{
			Console.WriteLine("Kaffeerahm hinzugefügt.");
		}
		#endregion
	}
}