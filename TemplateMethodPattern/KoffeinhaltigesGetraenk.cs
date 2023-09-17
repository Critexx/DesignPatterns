namespace TemplateMethodPattern
{
	internal abstract class KoffeinhaltigesGetraenk
	{
		#region Internals
		internal void RezeptZubereiten()
		{
			KocheWasser();
			Aufgiessen();
			InTasseSchuetten();
			ZutatenHinzufuegen();
		}

		protected abstract void Aufgiessen();
		protected abstract void ZutatenHinzufuegen();

		protected void KocheWasser()
		{
			Console.WriteLine("Wasser wird aufgekocht..");
		}

		protected void InTasseSchuetten()
		{
			Console.WriteLine("Getränk wird in die Tasse geschüttet.");
		}
		#endregion
	}
}