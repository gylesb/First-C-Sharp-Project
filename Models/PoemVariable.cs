namespace Poem.Models
{
  public class Poems
  {
    private string _recipient;

    public string GetRecipient()
    {
      return _recipient;
    }
    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }
  }
}
