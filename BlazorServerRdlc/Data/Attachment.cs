namespace BlazorServerRdlc.Data
{
	public class Attachment
	{
		public int Id { get; set; }
		public int PersonId { get; set; }
		public string FilePath { get; set; }

		public Person Person { get; set; }
	}
}
